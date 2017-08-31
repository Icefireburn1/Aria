using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using VideoLibrary;
using System.IO;
using System.Diagnostics;

namespace Aria
{
    public partial class Form1 : Form
    {
        public float progress;

        public Form1()
        {
            InitializeComponent();
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            progressBar1.Value = 0;
        }

        private void urlBox_Click(object sender, EventArgs e)
        {

        }

        private void dwnld_Button_Click(object sender, EventArgs e)
        {
            if (urlBox.Text.Contains("youtube.com/"))
            {
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("Please insert a Youtube URL.");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker backgroundWorker = (BackgroundWorker)sender;
            backgroundWorker.WorkerReportsProgress = true;

            YouTube youtube = new YouTube();
            Video video = youtube.GetVideo(urlBox.Text);

            string title = videoTitle.Text;//video.Title.Substring(0, video.Title.Length - 10);
            Byte[] videoBytes = video.GetBytes();
            String filePath = @"C:\Users\Icefireburn1\Videos\";
            FileStream fs = new FileStream(filePath + title + video.FileExtension, FileMode.Create,FileAccess.Write);
            for (int offset = 0; offset < videoBytes.Length; offset += 65536)
            {
                fs.Write(videoBytes, offset, Math.Min(65536, videoBytes.Length - offset));
                float percent = ((float)offset / (float)videoBytes.Length) * 100f;
                
                backgroundWorker.ReportProgress((int)Math.Round(percent, MidpointRounding.AwayFromZero));

                Thread.Sleep(1);
            }
            fs.Dispose(); //Frees file so it can be converted to FLAC
            if (convertMp3.Checked)
            {
                toFlacFormat(filePath + title + video.FileExtension, filePath + title + ".flac");
                System.IO.File.Delete(filePath + title + video.FileExtension);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage >= 0 && e.ProgressPercentage <= 100)
            {
                progressBar1.Value = e.ProgressPercentage;
            }
        }

        private void toFlacFormat(string pathToMp4, string pathToFlac)
        {
            Process ffmpeg = new Process
            {
                StartInfo = {UseShellExecute = false, RedirectStandardError = true, FileName = @"C:\Users\Icefireburn1\Documents\Visual Studio 2017\Projects\Aria\ffmpeg.exe", CreateNoWindow = true}
            };

            String arguments =
                    String.Format(
                    @"-i ""{0}"" -c:a flac ""{1}""",
                    pathToMp4, pathToFlac);

            ffmpeg.StartInfo.Arguments = arguments;


            try
            {
                if (!ffmpeg.Start())
                {
                    System.Media.SystemSounds.Beep.Play();
                    MessageBox.Show("Error starting");
                    return;
                }
                StreamReader reader = ffmpeg.StandardError;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Debug.WriteLine(line);
                }
            }
            catch (Exception exception)
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show(exception.ToString());
                return;
            }

            ffmpeg.Close();
        }

        private void urlBox_TextChanged(object sender, EventArgs e)
        {
            if (urlBox.Text.Contains("youtube.com/"))
            {
                YouTube youtube = new YouTube();
                Video video = youtube.GetVideo(urlBox.Text);
                videoTitle.Text = video.Title.Substring(0, video.Title.Length - 10);
            }
        }
    }
}
