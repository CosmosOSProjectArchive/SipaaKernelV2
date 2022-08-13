using Cosmos.System.Graphics;
using SipaaKernelV2.UI;
using SipaaKernelV2.UI.SysTheme;

namespace SipaaKernelV2.Applications.BootScreen
{
    internal class BootView : View
    {
        
        internal override void Draw(Canvas c)
        {
            c.DrawFilledRectangle(new Pen(ThemeManager.GetCurrentTheme().BackColor), 0, 0, (int)Kernel.ScreenWidth, (int)Kernel.ScreenHeight);
            c.DrawImage(Bitmaps.logo, (int)Kernel.ScreenWidth / 2 - (int)Bitmaps.logo.Width / 2, 300);
            int swidth = "Booting up...".Length * Kernel.font.Width;
            c.DrawString("Booting up...", Kernel.font, new Pen(ThemeManager.GetCurrentTheme().ForeColor), (int)Kernel.ScreenWidth / 2 - swidth / 2, 600);
        }

        internal override void Update()
        {
        }
    }
}