using Cosmos.System.Graphics;
using SipaaKernelV2.UI;
using System.Drawing;
using System;
namespace SipaaKernelV2.Applications.CrashScreen
{
    internal class CrashScreenView : View
    {
        Exception ex;
        internal CrashScreenView(Exception ex)
        {
            this.ex = ex;
        }
        private int GetFontWidth(string text)
        {
            return text.Length * Kernel.font.Width;
        }
        internal override void Draw(Canvas c)
        {
            int errorX = (int)Kernel.ScreenWidth / 2 - (int)Bitmaps.error.Width / 2;
            int problemX = (int)Kernel.ScreenWidth / 2 - GetFontWidth("SipaaKernel ran into a problem...") / 2;
            int sorryX = (int)Kernel.ScreenWidth / 2 - GetFontWidth("We are sorry for this exception, If this problem continue,") / 2;
            int reportX = (int)Kernel.ScreenWidth / 2 - GetFontWidth("report it to the SipaaKernel Discord Server") / 2;
            int exceptionInfoX = (int)Kernel.ScreenWidth / 2 - GetFontWidth(ex.GetType().FullName + " : " + ex.Message) / 2;
            c.DrawFilledRectangle(new Pen(Color.FromArgb(237, 28, 36)), 0,0, (int)Kernel.ScreenWidth, (int)Kernel.ScreenHeight);
            c.DrawImage(Bitmaps.error, errorX, 40);
            c.DrawString("SipaaKernel ran into a problem...", Kernel.font, ColorPens.whitePen, problemX, 40 + (int)Bitmaps.error.Height + 15);
            c.DrawString("We are sorry for this exception, If this problem continue,", Kernel.font, ColorPens.whitePen, sorryX, 40 + (int)Bitmaps.logo.Height + 30);
            c.DrawString("report it to the SipaaKernel Discord Server.", Kernel.font, ColorPens.whitePen, reportX, 40 + (int)Bitmaps.logo.Height + 45);
            c.DrawString(ex.GetType().FullName + " : " + ex.Message, Kernel.font, ColorPens.whitePen, exceptionInfoX, (int)Kernel.ScreenHeight - 10 - Kernel.font.Height);
        }

        internal override void Update()
        {
        }
    }
}