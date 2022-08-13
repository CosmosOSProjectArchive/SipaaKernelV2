namespace SipaaKernelV2Downloader
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.win32ThemeLabel1 = new CWinForms.Controls.Win32ThemeLabel();
            this.win32ThemeLabel2 = new CWinForms.Controls.Win32ThemeLabel();
            this.win32ThemeLabel3 = new CWinForms.Controls.Win32ThemeLabel();
            this.win32Button1 = new CWinForms.Controls.Win32Button();
            this.SuspendLayout();
            // 
            // win32ThemeLabel1
            // 
            this.win32ThemeLabel1.Font = new System.Drawing.Font("Segoe UI Light", 28.25F);
            this.win32ThemeLabel1.ForeColor = System.Drawing.Color.White;
            this.win32ThemeLabel1.Location = new System.Drawing.Point(1, 45);
            this.win32ThemeLabel1.Name = "win32ThemeLabel1";
            this.win32ThemeLabel1.Size = new System.Drawing.Size(574, 52);
            this.win32ThemeLabel1.TabIndex = 0;
            this.win32ThemeLabel1.Text = "<S> SipaaKernel V2";
            this.win32ThemeLabel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // win32ThemeLabel2
            // 
            this.win32ThemeLabel2.Font = new System.Drawing.Font("Segoe UI Light", 16.25F);
            this.win32ThemeLabel2.ForeColor = System.Drawing.Color.White;
            this.win32ThemeLabel2.Location = new System.Drawing.Point(1, 173);
            this.win32ThemeLabel2.Name = "win32ThemeLabel2";
            this.win32ThemeLabel2.Size = new System.Drawing.Size(574, 29);
            this.win32ThemeLabel2.TabIndex = 1;
            this.win32ThemeLabel2.Text = "Welcome to the SipaaKernel V2 Downloader!";
            this.win32ThemeLabel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // win32ThemeLabel3
            // 
            this.win32ThemeLabel3.Font = new System.Drawing.Font("Segoe UI Light", 16.25F);
            this.win32ThemeLabel3.ForeColor = System.Drawing.Color.White;
            this.win32ThemeLabel3.Location = new System.Drawing.Point(1, 208);
            this.win32ThemeLabel3.Name = "win32ThemeLabel3";
            this.win32ThemeLabel3.Size = new System.Drawing.Size(574, 29);
            this.win32ThemeLabel3.TabIndex = 2;
            this.win32ThemeLabel3.Text = "This program will guide you in the download process.";
            this.win32ThemeLabel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // win32Button1
            // 
            this.win32Button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.win32Button1.Location = new System.Drawing.Point(251, 266);
            this.win32Button1.Name = "win32Button1";
            this.win32Button1.Size = new System.Drawing.Size(75, 29);
            this.win32Button1.TabIndex = 3;
            this.win32Button1.Text = "Next >";
            this.win32Button1.UseVisualStyleBackColor = true;
            this.win32Button1.Click += new System.EventHandler(this.win32Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.win32Button1);
            this.Controls.Add(this.win32ThemeLabel3);
            this.Controls.Add(this.win32ThemeLabel2);
            this.Controls.Add(this.win32ThemeLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SipaaKernel V2 Downloader";
            this.ResumeLayout(false);

        }

        #endregion

        private CWinForms.Controls.Win32ThemeLabel win32ThemeLabel1;
        private CWinForms.Controls.Win32ThemeLabel win32ThemeLabel2;
        private CWinForms.Controls.Win32ThemeLabel win32ThemeLabel3;
        private CWinForms.Controls.Win32Button win32Button1;
    }
}

