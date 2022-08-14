using Cosmos.System.Graphics;
using SipaaKernelV2.Core.Graphics;
using SipaaKernelV2.UI;
using Desk = SipaaKernelV2.Applications.SipaaDesktop.SipaaDesktop;

namespace SipaaKernelV2.Applications.UIGallery
{
    internal class UIGalleryView : View
    {
        Button closeButton, sampleButton;
        TextBox sampleTextBox;
        TextView sampleTextView;
        Panel samplePanel;
        private List sampleList;

        internal UIGalleryView()
        {
            this.sampleButton = new Button("Sample Button", 8, 52, 200, 40);
            this.sampleButton.Bitmap = Bitmaps.cursor;
            this.sampleTextView = new TextView("Click on Sample Button to toggle sample panel visibility.", 8, 38);
            this.sampleTextBox = new TextBox(8, 138);
            this.samplePanel = new Panel(8, sampleTextBox.Y + 6, 200, 200);
            this.sampleList = new List(8, 200 + samplePanel.Height + 6);
            sampleList.AddButton(new Button("never", 0, 0));
            sampleList.AddButton(new Button("gonna", 0, 0));
            sampleList.AddButton(new Button("give", 0, 0));
            sampleList.AddButton(new Button("you", 0, 0));
            sampleList.AddButton(new Button("up", 0, 0));
            this.closeButton = new Button("X", Kernel.ScreenWidth - 24, 0,24, 32);
        }

        internal override void Draw(FrameBuffer c)
        {
            c.DrawFilledRectangle(0, 0, (int)Kernel.ScreenWidth, (int)Kernel.ScreenHeight, 0, Color.Black);
            c.DrawFilledRectangle(0, 0, (int)Kernel.ScreenWidth, 32, 0, Color.FromARGB(0, 32, 32, 32));
            c.DrawString(24 + 9, 10, "SipaaKernel UI Library", Kernel.font, Color.White);
            c.DrawImage(4, 32 / 2 - (int)Bitmaps.uilib.Width / 2, Bitmaps.uilib, true);
            closeButton.Draw(c);
            sampleButton.Draw(c);
            sampleTextView.Draw(c);
            samplePanel.Draw(c);
            sampleTextBox.Draw(c);
            sampleList.Draw(c);
        }

        internal override void Update()
        {
            closeButton.Update();
            samplePanel.Update();
            sampleButton.Update();
            sampleTextBox.Update();
            sampleTextView.Update();
            sampleList.Update();

            if (closeButton.ButtonState == ButtonState.Clicked)
            {
                Kernel.OpenApplication(new Desk());
            }
            if (sampleButton.ButtonState == ButtonState.Clicked)
            {
                samplePanel.Visible = !samplePanel.Visible;
            }
        }
    }
}