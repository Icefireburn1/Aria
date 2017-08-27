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
            if (convertMp3.Checked)
            {

            }
            else
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void findNum()
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker backgroundWorker = (BackgroundWorker)sender;
            backgroundWorker.WorkerReportsProgress = true;

            YouTube youtube = new YouTube();
            Video video = youtube.GetVideo(urlBox.Text);

            string title = video.Title;
            Byte[] videoBytes = video.GetBytes();

            FileStream fs = new FileStream(@"C:\Users\Icefireburn1\Videos\" + video.FullName, FileMode.Create,FileAccess.Write);
            for (int offset = 0; offset < videoBytes.Length; offset += 65536)
            {
                fs.Write(videoBytes, offset, Math.Min(65536, videoBytes.Length - offset));
                float percent = ((float)offset / (float)videoBytes.Length) * 100f;
                
                backgroundWorker.ReportProgress((int)Math.Round(percent, MidpointRounding.AwayFromZero));

                Thread.Sleep(1);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage >= 0 && e.ProgressPercentage <= 100)
            {
                progressBar1.Value = e.ProgressPercentage;
            }
        }
    }
}
