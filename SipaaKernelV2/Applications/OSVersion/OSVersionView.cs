using Cosmos.System.Graphics;
using SipaaKernelV2.UI;

namespace SipaaKernelV2.Applications.OSVersion
{
    internal class OSVersionView : View
    {
        Button closeButton;
        internal OSVersionView()
        {
            this.closeButton = new Button("X", Kernel.ScreenWidth - 24, 0,24, 32);
        }

        internal override void Draw(Canvas c)
        {
            c.DrawFilledRectangle(ColorPens.idleButtonPen, 0,0, (int)Kernel.ScreenWidth, (int)Kernel.ScreenHeight);
            c.DrawFilledRectangle(ColorPens.hoverButtonPen, 0, 0, (int)Kernel.ScreenWidth, 32);
            c.DrawString("About " + Kernel.OSName, Kernel.font, ColorPens.whitePen, 24 + 9, 10);
            c.DrawImageAlpha(Bitmaps.about, 4, 32 / 2 - (int)Bitmaps.about.Width / 2);
            c.DrawImage(Bitmaps.logo, 8, 40);
            c.DrawString(Kernel.OSName, Kernel.font, ColorPens.whitePen, 10, 40 + (int)Bitmaps.logo.Height + 15);
            c.DrawString("Version " + Kernel.OSVersion + " (build " + Kernel.OSBuild + ")", Kernel.font, ColorPens.whitePen, 10, 40 + (int)Bitmaps.logo.Height + 30);
            c.DrawString("Made with <3 by RaphMar2019", Kernel.font, ColorPens.whitePen, 10, 40 + (int)Bitmaps.logo.Height + 45);
            c.DrawString("Special thanks to the Cosmos team (Without Cosmos, this OS isn't possible!)", Kernel.font, ColorPens.whitePen, 10, 40 + (int)Bitmaps.logo.Height + 60);
            c.DrawString("Thanks to xyve#5469 for the text editor idea,", Kernel.font, ColorPens.whitePen, 10, 40 + (int)Bitmaps.logo.Height + 60 + Kernel.font.Height + 6);
            c.DrawString("Kokolor#5434 for File Explorer, Boot Screen!", Kernel.font, ColorPens.whitePen, 10, 40 + (int)Bitmaps.logo.Height + 60 + Kernel.font.Height * 2 + 6);
            closeButton.Draw(c);
        }

        internal override void Update()
        {
            closeButton.Update();

            if (closeButton.ButtonState == ButtonState.Clicked)
            {
                Kernel.OpenApplication(Kernel.apps[0]);
            }
        }
    }
}