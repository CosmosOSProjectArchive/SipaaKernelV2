namespace SipaaKernelV2Downloader
{
    partial class DownloadForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.win32ThemeLabel1 = new CWinForms.Controls.Win32ThemeLabel();
            this.win32ProgressBar1 = new CWinForms.Controls.Win32ProgressBar();
            this.win32ThemeLabel2 = new CWinForms.Controls.Win32ThemeLabel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.win32ThemeLabel2);
            this.panel2.Controls.Add(this.win32ProgressBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 402);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.win32ThemeLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 48);
            this.panel1.TabIndex = 2;
            // 
            // win32ThemeLabel1
            // 
            this.win32ThemeLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.win32ThemeLabel1.ForeColor = System.Drawing.Color.White;
            this.win32ThemeLabel1.Location = new System.Drawing.Point(12, 3);
            this.win32ThemeLabel1.Name = "win32ThemeLabel1";
            this.win32ThemeLabel1.Size = new System.Drawing.Size(243, 42);
            this.win32ThemeLabel1.TabIndex = 0;
            this.win32ThemeLabel1.Text = "Downloading SipaaKernel...";
            this.win32ThemeLabel1.TextAlignVertical = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            // 
            // win32ProgressBar1
            // 
            this.win32ProgressBar1.Location = new System.Drawing.Point(157, 101);
            this.win32ProgressBar1.Name = "win32ProgressBar1";
            this.win32ProgressBar1.Size = new System.Drawing.Size(260, 29);
            this.win32ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.win32ProgressBar1.TabIndex = 0;
            this.win32ProgressBar1.Value = 25;
            // 
            // win32ThemeLabel2
            // 
            this.win32ThemeLabel2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.win32ThemeLabel2.ForeColor = System.Drawing.Color.White;
            this.win32ThemeLabel2.Location = new System.Drawing.Point(188, 53);
            this.win32ThemeLabel2.Name = "win32ThemeLabel2";
            this.win32ThemeLabel2.Size = new System.Drawing.Size(196, 42);
            this.win32ThemeLabel2.TabIndex = 1;
            this.win32ThemeLabel2.Text = "Downloading SipaaKernel... This may take a while";
            this.win32ThemeLabel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.win32ThemeLabel2.TextAlignVertical = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            // 
            // DownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DownloadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Downloading SipaaKernel...";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private CWinForms.Controls.Win32ThemeLabel win32ThemeLabel1;
        private CWinForms.Controls.Win32ProgressBar win32ProgressBar1;
        private CWinForms.Controls.Win32ThemeLabel win32ThemeLabel2;
    }
}