using Cosmos.System.Graphics;
using SipaaKernelV2.UI;

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

        internal override void Draw(Canvas c)
        {
            c.DrawFilledRectangle(ColorPens.idleButtonPen, 0,0, (int)Kernel.ScreenWidth, (int)Kernel.ScreenHeight);
            c.DrawFilledRectangle(ColorPens.hoverButtonPen, 0, 0, (int)Kernel.ScreenWidth, 32);
            c.DrawString("Sipad", Kernel.font, ColorPens.whitePen, 24 + 9, 10);
            c.DrawImageAlpha(Bitmaps.sipad, 4, 32 / 2 - (int)Bitmaps.sipad.Width / 2);
            closeButton.Draw(c);
            tbDoc.Draw(c);
        }

        internal override void Update()
        {
            closeButton.Update();
            tbDoc.Update();
            if (closeButton.ButtonState == ButtonState.Clicked)
            {
                Kernel.OpenApplication(Kernel.apps[0]);
            }
        }
    }
}