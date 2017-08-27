namespace Aria
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dwnld_Button = new System.Windows.Forms.Button();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.convertMp3 = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // dwnld_Button
            // 
            this.dwnld_Button.Location = new System.Drawing.Point(101, 171);
            this.dwnld_Button.Name = "dwnld_Button";
            this.dwnld_Button.Size = new System.Drawing.Size(75, 23);
            this.dwnld_Button.TabIndex = 0;
            this.dwnld_Button.Text = "Download";
            this.dwnld_Button.UseVisualStyleBackColor = true;
            this.dwnld_Button.Click += new System.EventHandler(this.dwnld_Button_Click);
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(56, 200);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(169, 20);
            this.urlBox.TabIndex = 1;
            this.urlBox.WordWrap = false;
            this.urlBox.Click += new System.EventHandler(this.urlBox_Click);
            // 
            // convertMp3
            // 
            this.convertMp3.AutoSize = true;
            this.convertMp3.Location = new System.Drawing.Point(176, 177);
            this.convertMp3.Name = "convertMp3";
            this.convertMp3.Size = new System.Drawing.Size(49, 17);
            this.convertMp3.TabIndex = 2;
            this.convertMp3.Text = ",mp3";
            this.convertMp3.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 238);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(284, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.convertMp3);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.dwnld_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dwnld_Button;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.CheckBox convertMp3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

