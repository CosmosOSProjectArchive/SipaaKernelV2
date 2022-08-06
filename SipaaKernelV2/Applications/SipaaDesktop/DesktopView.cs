using Cosmos.System.Graphics;
using SipaaKernelV2.UI;
namespace SipaaKernelV2.Applications.SipaaDesktop
{
    internal class DesktopView : View
    {
        Button openOSVersion;
        TextBox testTextBox;
        internal DesktopView()
        {
            openOSVersion = new Button("OS Version", 8, 8 + (uint)Kernel.font.Height + 2);
            testTextBox = new TextBox(200, 8 + (uint)Kernel.font.Height + 2);
        }
        internal override void Draw(Canvas c)
        {
            c.DrawImage(Kernel.wallpaper, 0, 0);
            c.DrawString("Hello World, Its the Desktop!", Kernel.font, ColorPens.whitePen, 8, 8);
            openOSVersion.Draw(c);
            testTextBox.Draw(c);
        }

        internal override void Update()
        {
            openOSVersion.Update();
            testTextBox.Update();
            if (openOSVersion.ButtonState == ButtonState.Clicked)
            {
                Kernel.OpenApplication(Kernel.apps[1]);
            }
        }
    }
}