using Cosmos.System.Graphics;
using SipaaKernelV2.UI;

namespace SipaaKernelV2.Applications.UIGallery
{
    internal class UIGalleryView : View
    {
        Button closeButton, sampleButton;
        TextBox sampleTextBox;
        TextView sampleTextView;
        CheckBox sampleCheckBox;
        Panel samplePanel;
        private List sampleList;

        internal UIGalleryView()
        {
            this.sampleButton = new Button("Sample Button", 8, 52, 200, 40);
            this.sampleButton.Bitmap = Bitmaps.cursor;
            this.sampleTextView = new TextView("Click on Sample Button to toggle sample panel visibility.", 8, 38);
            this.sampleTextBox = new TextBox(8, 138);
            this.sampleCheckBox = new CheckBox("Do you like SipaaKernel?", 8, 100);
            this.samplePanel = new Panel(8, sampleTextBox.Y + 6, 200, 200);
            this.sampleList = new List(8, 200 + samplePanel.Height + 6);
            sampleList.AddButton(new Button("never", 0, 0));
            sampleList.AddButton(new Button("gonna", 0, 0));
            sampleList.AddButton(new Button("give", 0, 0));
            sampleList.AddButton(new Button("you", 0, 0));
            sampleList.AddButton(new Button("up", 0, 0));
            this.closeButton = new Button("X", Kernel.ScreenWidth - 24, 0,24, 32);
        }

        internal override void Draw(Canvas c)
        {
            c.DrawFilledRectangle(ColorPens.blackPen, 0,0, (int)Kernel.ScreenWidth, (int)Kernel.ScreenHeight);
            c.DrawFilledRectangle(ColorPens.hoverButtonPen, 0, 0, (int)Kernel.ScreenWidth, 32);
            c.DrawString("SipaaKernel UI Library", Kernel.font, ColorPens.whitePen, 24 + 9, 10);
            c.DrawImageAlpha(Bitmaps.uilib, 4, 32 / 2 - (int)Bitmaps.uilib.Width / 2);
            closeButton.Draw(c);
            sampleButton.Draw(c);
            sampleCheckBox.Draw(c);
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
            sampleCheckBox.Update();
            sampleTextBox.Update();
            sampleTextView.Update();
            sampleList.Update();

            if (closeButton.ButtonState == ButtonState.Clicked)
            {
                Kernel.OpenApplication(Kernel.apps[0]);
            }
            if (sampleButton.ButtonState == ButtonState.Clicked)
            {
                samplePanel.Visible = !samplePanel.Visible;
            }
        }
    }
}