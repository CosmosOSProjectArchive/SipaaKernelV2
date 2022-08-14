using SipaaKernelV2.Core.Graphics;
using SipaaKernelV2.UI;
using Desk = SipaaKernelV2.Applications.SipaaDesktop.SipaaDesktop;

namespace SipaaKernelV2.Applications.Sipad
{
    internal class SipadView : View
    {
        Button closeButton;
        TextBox tbDoc;
        internal SipadView()
        {
            this.closeButton = new Button("X", Kernel.ScreenWidth - 24, 0,24, 32);
            tbDoc = new TextBox(0, 32);
            tbDoc.Focus = false;
            tbDoc.Multiline = true;
            tbDoc.Width = Kernel.ScreenWidth;
            tbDoc.Height = Kernel.ScreenHeight - 32 + 48;
        }

        internal override void Draw(FrameBuffer c)
        {
            c.DrawFilledRectangle(0, 0, (int)Kernel.ScreenWidth, (int)Kernel.ScreenHeight, 0, Color.Black);
            c.DrawFilledRectangle(0, 0, (int)Kernel.ScreenWidth, 32, 0, Color.FromARGB(0, 32, 32, 32));
            c.DrawString(24 + 9, 10, "SipaaKernel UI Library", Kernel.font, Color.White);
            c.DrawImage(4, 32 / 2 - (int)Bitmaps.uilib.Width / 2, Bitmaps.uilib, true);
            closeButton.Draw(c);
            tbDoc.Draw(c);
        }

        internal override void Update()
        {
            closeButton.Update();
            tbDoc.Update();
            if (closeButton.ButtonState == ButtonState.Clicked)
            {
                Kernel.OpenApplication(new Desk());
            }
        }
    }
}