using Cosmos.System.Graphics;
using SipaaKernelV2.Core.Graphics;
using SipaaKernelV2.UI;
using System.IO;
using Desk = SipaaKernelV2.Applications.SipaaDesktop.SipaaDesktop;
namespace SipaaKernelV2.Applications.FileExplorer
{
    internal class FileExplorerView : View
    {
        Button closeButton;
        Button mainDrive;
        List fileDirList;
        List shortAcessList;
        public FileExplorerView()
        {
            closeButton = new Button("X", Kernel.ScreenWidth - 24, 0, 24, 32);
            shortAcessList = new List(3, 35, 250, Kernel.ScreenHeight - 32 - 6);
            fileDirList = new List(256, 35, Kernel.ScreenWidth - 9 - 250, Kernel.ScreenHeight - 32 - 6);
            mainDrive = new Button(@"0:\", 0, 0);
            mainDrive.Bitmap = Bitmaps.ssd;
            shortAcessList.AddButton(mainDrive);
        }
        internal override void Draw(FrameBuffer c)
        {
            c.DrawFilledRectangle(0, 0, (int)Kernel.ScreenWidth, (int)Kernel.ScreenHeight, 0, Color.Black);
            c.DrawFilledRectangle(0, 0, (int)Kernel.ScreenWidth, 32, 0, Color.FromARGB(0, 32, 32, 32));
            c.DrawString(24 + 9, 10, "File Explorer", Kernel.font, Color.White);
            c.DrawImage(4, 32 / 2 - (int)Bitmaps.uilib.Width / 2, Bitmaps.folder, true);
            closeButton.Draw(c);
            shortAcessList.Draw(c);
            fileDirList.Draw(c);
        }
        private void NavigateTo(string dir)
        {
            if (Directory.Exists(dir))
            {
                fileDirList.RemoveAllButtons();
                foreach (string d in Directory.GetDirectories(dir))
                {
                    FileInfo i = new FileInfo(d);
                    Button b = new Button(i.Name + " (Directory)", 0, 0) { Bitmap = Bitmaps.folder };
                    fileDirList.AddButton(b);
                }
                foreach (string f in Directory.GetFiles(dir))
                {
                    FileInfo i = new FileInfo(f);
                    Button b = new Button(i.Name, 0, 0) { Bitmap = Bitmaps.file };
                    fileDirList.AddButton(b);
                }
            }
        }
        internal override void Update()
        {
            closeButton.Update();
            shortAcessList.Update();
            fileDirList.Update();
            if (mainDrive.ButtonState == ButtonState.Clicked)
            {
                NavigateTo(@"0:\");
            }
            if (closeButton.ButtonState == ButtonState.Clicked)
            {
                Kernel.OpenApplication(new Desk());
            }
        }
    }
}