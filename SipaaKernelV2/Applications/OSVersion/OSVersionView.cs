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
            c.DrawString("About " + Kernel.OSName, Kernel.font, ColorPens.whitePen, 10, 10);
            c.DrawImage(Kernel.logo, 8, 40);
            c.DrawString(Kernel.OSName, Kernel.font, ColorPens.whitePen, 10, 40 + (int)Kernel.logo.Height + 15);
            c.DrawString("Version " + Kernel.OSVersion + " (build " + Kernel.OSBuild + ")", Kernel.font, ColorPens.whitePen, 10, 40 + (int)Kernel.logo.Height + 30);
            c.DrawString("Made with <3 by RaphMar2019", Kernel.font, ColorPens.whitePen, 10, 40 + (int)Kernel.logo.Height + 45);
            c.DrawString("Special thanks to the Cosmos team (Without Cosmos, this OS isn't possible!)", Kernel.font, ColorPens.whitePen, 10, 40 + (int)Kernel.logo.Height + 60);
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