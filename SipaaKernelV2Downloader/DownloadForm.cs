using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CWinForms;

namespace SipaaKernelV2Downloader
{
    public partial class DownloadForm : Form
    {
        WebClient client;
        public DownloadForm()
        {
            InitializeComponent();
            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
            client.DownloadFile("https://github.com/RaphMar2021/SipaaKernelV2/releases/download/22H2-PR1", "SipaaKernelV2.iso");
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            new DownloadCompleteForm().Show();
            this.Close();
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            win32ProgressBar1.Value = e.ProgressPercentage;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case (int)WindowMessage.WM_CREATE:
                    WindowsHelper.ExtendFrameIntoClientArea(Handle, WindowsHelper.defaultmargins);
                    Win10Helper.EnableDarkMode(Handle, DWM_BOOL.DWMWCP_TRUE);
                    Win11Helper.SetMica(Handle, DWM_BOOL.DWMWCP_TRUE);
                    break;
            }
        }
    }
}
