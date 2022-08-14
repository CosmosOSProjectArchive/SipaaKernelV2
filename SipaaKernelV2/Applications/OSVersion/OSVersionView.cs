using SipaaKernelV2.Core.Graphics;
using SipaaKernelV2.UI;
using Desk = SipaaKernelV2.Applications.SipaaDesktop.SipaaDesktop;

namespace SipaaKernelV2.Applications.OSVersion
{
    internal class OSVersionView : View
    {
        Button closeButton;
        internal OSVersionView()
        {
            this.closeButton = new Button("X", Kernel.ScreenWidth - 24, 0,24, 32);
        }

        internal override void Draw(FrameBuffer c)
        {
            c.DrawFilledRectangle(0, 0, (int)Kernel.ScreenWidth, (int)Kernel.ScreenHeight, 0, Color.Black);
            c.DrawFilledRectangle(0, 0, (int)Kernel.ScreenWidth, 32, 0, Color.FromARGB(0, 32, 32, 32));
            c.DrawString(24 + 9, 10, "SipaaKernel UI Library", Kernel.font, Color.White);
            c.DrawImage(4, 32 / 2 - (int)Bitmaps.uilib.Width / 2, Bitmaps.uilib, true);
            c.DrawImage(8, 40, Bitmaps.logo);
            c.DrawString(10, 40 + (int)Bitmaps.logo.Height + 15, Kernel.OSName, Kernel.font, Color.White);
            c.DrawString(10, 40 + (int)Bitmaps.logo.Height + 30, "Version " + Kernel.OSVersion + " (build " + Kernel.OSBuild + ")", Kernel.font, Color.White);
            c.DrawString(10, 40 + (int)Bitmaps.logo.Height + 45, "Made with <3 by RaphMar2019", Kernel.font, Color.White);
            c.DrawString(10, 40 + (int)Bitmaps.logo.Height + 60, "Special thanks to the Cosmos team (Without Cosmos, this OS isn't possible!)", Kernel.font, Color.White);
            c.DrawString(10, 40 + (int)Bitmaps.logo.Height + 75, "Thanks to xyve#5469 for the text editor idea,", Kernel.font, Color.White);
            c.DrawString(10, 40 + (int)Bitmaps.logo.Height + 90, "Kokolor#5434 for File Explorer, Boot Screen!", Kernel.font, Color.White);
            closeButton.Draw(c);
        }

        internal override void Update()
        {
            closeButton.Update();

            if (closeButton.ButtonState == ButtonState.Clicked)
            {
                Kernel.OpenApplication(new Desk());
            }
        }
    }
}