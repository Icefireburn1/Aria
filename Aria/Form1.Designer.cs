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
            this.SuspendLayout();
            // 
            // dwnld_Button
            // 
            this.dwnld_Button.Location = new System.Drawing.Point(103, 226);
            this.dwnld_Button.Name = "dwnld_Button";
            this.dwnld_Button.Size = new System.Drawing.Size(75, 23);
            this.dwnld_Button.TabIndex = 0;
            this.dwnld_Button.Text = "button1";
            this.dwnld_Button.UseVisualStyleBackColor = true;
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(91, 171);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(100, 20);
            this.urlBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
    }
}

