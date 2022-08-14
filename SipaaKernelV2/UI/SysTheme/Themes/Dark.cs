using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SipaaKernelV2.Core.Graphics;

namespace SipaaKernelV2.UI.SysTheme.Themes
{
    internal class Dark : ThemeBase
    {
        public Dark()
        {
            ThemeId = 0;
            ThemeName = "SipaaKernel Dark";

            BorderSize = 0;
            BorderColor = Color.Black;

            BackColor = Color.FromARGB(0, 32, 32, 32);
            HoveredBackColor = Color.FromARGB(0, 64, 64, 64);
            ClickedBackColor = Color.FromARGB(0, 12, 12, 12);

            ForeColor = Color.White;
        }
    }
}
