using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SipaaKernelV2.Core.Graphics;

namespace SipaaKernelV2.UI.SysTheme.Themes
{
    internal class Light : ThemeBase
    {
        public Light()
        {
            ThemeId = 1;
            ThemeName = "SipaaKernel Light";

            BorderColor = Color.White;

            BackColor = Color.FromARGB(0, 223, 223, 223);
            HoveredBackColor = Color.FromARGB(0, 191, 191, 191);
            ClickedBackColor = Color.FromARGB(0, 243, 243, 243);

            ForeColor = Color.Black;
        }
    }
}
