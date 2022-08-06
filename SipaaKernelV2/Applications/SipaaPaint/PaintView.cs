using Cosmos.System.Graphics;
using SipaaKernelV2.UI;

namespace SipaaKernelV2.Applications.SipaaPaint
{
    internal class PaintView : View
    {
        Button closeButton;
        internal PaintView()
        {
            this.closeButton = new Button("X", Kernel.ScreenWidth - 24, 0,24, 32);
        }

        internal override void Draw(Canvas c)
        {
            c.DrawFilledRectangle(ColorPens.whitePen, 0,0, (int)Kernel.ScreenWidth, (int)Kernel.ScreenHeight);
            c.DrawFilledRectangle(ColorPens.hoverButtonPen, 0, 0, (int)Kernel.ScreenWidth, 32);
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