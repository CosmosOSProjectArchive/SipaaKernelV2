using Cosmos.System.Graphics;
using SipaaKernelV2.UI;
using System;
using SipaaKernelV2.Core.Graphics;

namespace SipaaKernelV2.Applications.CrashScreen
{
    internal class CrashScreenView : View
    {
        Exception ex;
        internal CrashScreenView(Exception ex)
        {
            this.ex = ex;
        }
        internal override void Draw(FrameBuffer c)
        {
            int errorX = (int)Kernel.ScreenWidth / 2 - (int)Bitmaps.error.Width / 2;
            int problemX = (int)Kernel.ScreenWidth / 2 - (int)Kernel.font.MeasureString("SipaaKernel ran into a problem...") / 2;
            int sorryX = (int)Kernel.ScreenWidth / 2 - (int)Kernel.font.MeasureString("We are sorry for this exception, If this problem continue,") / 2;
            int reportX = (int)Kernel.ScreenWidth / 2 - (int)Kernel.font.MeasureString("report it to the SipaaKernel Discord Server") / 2;
            int exceptionInfoX = (int)Kernel.ScreenWidth / 2 - (int)Kernel.font.MeasureString(ex.GetType().FullName + " : " + ex.Message) / 2;
            c.DrawFilledRectangle(0, 0, (int)Kernel.ScreenWidth, (int)Kernel.ScreenHeight, 0, Color.FromARGB(0, 237, 28, 36));
            c.DrawImage(errorX, 40, Bitmaps.error);
            c.DrawString(problemX, 40 + (int)Bitmaps.error.Height + 15, "SipaaKernel ran into a problem...", Kernel.font, Color.White);
            c.DrawString(sorryX, 40 + (int)Bitmaps.error.Height + 30, "We are sorry for this exception, If this problem continue,", Kernel.font, Color.White);
            c.DrawString(reportX, 40 + (int)Bitmaps.error.Height + 45, "report it to the SipaaKernel Discord Server.", Kernel.font, Color.White);
            c.DrawString(exceptionInfoX, 40 + (int)Bitmaps.error.Height + 15, ex.GetType().FullName + " : " + ex.Message, Kernel.font, Color.White);
        }

        internal override void Update()
        {
        }
    }
}