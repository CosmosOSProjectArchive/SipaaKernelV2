using Cosmos.System.Graphics;
using SipaaKernelV2.Core.Graphics;
using SipaaKernelV2.UI;
using SipaaKernelV2.UI.SysTheme;

namespace SipaaKernelV2.Applications.BootScreen
{
    internal class BootView : View
    {
        
        internal override void Draw(FrameBuffer c)
        {
            c.DrawFilledRectangle(0, 0, (int)Kernel.ScreenWidth, (int)Kernel.ScreenHeight, 0, ThemeManager.GetCurrentTheme().BackColor);
            int imagey = (int)Kernel.ScreenHeight / 2 - (int)Bitmaps.logo.Height / 2;
            c.DrawImage((int)Kernel.ScreenWidth / 2 - (int)Bitmaps.logo.Width / 2, imagey, Bitmaps.logo, false);
            int swidth = (int)Kernel.font.MeasureString("Booting up...");
            c.DrawString((int)Kernel.ScreenWidth / 2 - swidth / 2, imagey + (int)Bitmaps.logo.Height + 12 + 10, "Booting up...", Kernel.font, ThemeManager.GetCurrentTheme().ForeColor);
        }

        internal override void Update()
        {
        }
    }
}