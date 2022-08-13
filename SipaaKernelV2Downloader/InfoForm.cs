using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CWinForms;
namespace SipaaKernelV2Downloader
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
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

        private void win32Button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void win32Button1_Click(object sender, EventArgs e)
        {
            new DownloadForm().Show();
            this.Close();
        }
    }
}
