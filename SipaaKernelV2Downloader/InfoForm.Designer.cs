namespace SipaaKernelV2Downloader
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.win32ThemeLabel1 = new CWinForms.Controls.Win32ThemeLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.win32Button1 = new CWinForms.Controls.Win32Button();
            this.win32Button2 = new CWinForms.Controls.Win32Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.win32ThemeLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 48);
            this.panel1.TabIndex = 0;
            // 
            // win32ThemeLabel1
            // 
            this.win32ThemeLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.win32ThemeLabel1.ForeColor = System.Drawing.Color.White;
            this.win32ThemeLabel1.Location = new System.Drawing.Point(12, 3);
            this.win32ThemeLabel1.Name = "win32ThemeLabel1";
            this.win32ThemeLabel1.Size = new System.Drawing.Size(46, 42);
            this.win32ThemeLabel1.TabIndex = 0;
            this.win32ThemeLabel1.Text = "Infos";
            this.win32ThemeLabel1.TextAlignVertical = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 354);
            this.panel2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(574, 354);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.win32Button2);
            this.panel3.Controls.Add(this.win32Button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 402);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(574, 48);
            this.panel3.TabIndex = 1;
            // 
            // win32Button1
            // 
            this.win32Button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.win32Button1.Location = new System.Drawing.Point(435, 6);
            this.win32Button1.Name = "win32Button1";
            this.win32Button1.Size = new System.Drawing.Size(127, 36);
            this.win32Button1.TabIndex = 0;
            this.win32Button1.Text = "DOWNLOAD NOW >";
            this.win32Button1.UseVisualStyleBackColor = true;
            this.win32Button1.Click += new System.EventHandler(this.win32Button1_Click);
            // 
            // win32Button2
            // 
            this.win32Button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.win32Button2.Location = new System.Drawing.Point(12, 6);
            this.win32Button2.Name = "win32Button2";
            this.win32Button2.Size = new System.Drawing.Size(75, 36);
            this.win32Button2.TabIndex = 1;
            this.win32Button2.Text = "CANCEL";
            this.win32Button2.UseVisualStyleBackColor = true;
            this.win32Button2.Click += new System.EventHandler(this.win32Button2_Click);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CWinForms.Controls.Win32ThemeLabel win32ThemeLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel3;
        private CWinForms.Controls.Win32Button win32Button1;
        private CWinForms.Controls.Win32Button win32Button2;
    }
}