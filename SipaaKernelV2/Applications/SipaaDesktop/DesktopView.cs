using Cosmos.HAL;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using SipaaKernelV2.Core;
using SipaaKernelV2.UI;
using SipaaKernelV2.UI.SysTheme;
using System;
using OSVer = SipaaKernelV2.Applications.OSVersion.OSVersion;
using Spad = SipaaKernelV2.Applications.Sipad.Sipad;
using UILib = SipaaKernelV2.Applications.UIGallery.UIGallery;
using FileEx = SipaaKernelV2.Applications.FileExplorer.FileExplorer;
using SipaaKernelV2.Core.Graphics;

namespace SipaaKernelV2.Applications.SipaaDesktop
{
    internal class DesktopView : View
    {
        Button openOSVersion, openUILibrary, openSipad,openFileExplorer, shutdown, consolemode, reboot, exButton;
        Panel appsPanel;
        internal DesktopView()
        { 
            //window = new Window(Kernel.ScreenWidth / 2 - 640 / 2, Kernel.ScreenHeight / 2 - 480 / 2, 640, 480);
            //window.Visible = true;
            appsPanel = new Panel(0, 0, 156, Kernel.ScreenHeight);
            appsPanel.Visible = false;

            shutdown = new Button("", Kernel.ScreenWidth - 40, Kernel.ScreenHeight - 40, 40, 40);
            reboot = new Button("", Kernel.ScreenWidth - 80, Kernel.ScreenHeight - 40, 40, 40);
            consolemode = new Button("", Kernel.ScreenWidth - 120, Kernel.ScreenHeight - 40, 40, 40);
            exButton = new Button("", Kernel.ScreenWidth - 160, Kernel.ScreenHeight - 40, 40, 40);

            openOSVersion = new Button("", 0, Kernel.ScreenHeight - 40, 40, 40);
            openUILibrary = new Button("", 40, Kernel.ScreenHeight - 40, 40, 40);
            openSipad = new Button("", 80, Kernel.ScreenHeight - 40, 40, 40);
            openFileExplorer = new Button("", 120, Kernel.ScreenHeight - 40, 40, 40);
           
            shutdown.Bitmap = Bitmaps.shutdown;
            reboot.Bitmap = Bitmaps.reboot;
            exButton.Bitmap = Bitmaps.throwex;
            consolemode.Bitmap = Bitmaps.consolemode;

            openOSVersion.Bitmap = Bitmaps.about;
            openUILibrary.Bitmap = Bitmaps.uilib;
            openSipad.Bitmap = Bitmaps.sipad;
            openFileExplorer.Bitmap = Bitmaps.folder;
        }
        internal override void Draw(FrameBuffer c)
        {
            c.DrawImage(0, 0, Bitmaps.wallpaper);
            c.DrawFilledRectangle(0, 0, (int)Kernel.ScreenWidth, 24, 0, ThemeManager.GetCurrentTheme().BackColor);
            c.DrawString(4, 4,"SipaaKernel V2 - Desktop", Kernel.font, ThemeManager.GetCurrentTheme().ForeColor);
            int timeWidth = (int)Kernel.font.MeasureString(RTC.Year + "/" + RTC.Month + "/" + RTC.DayOfTheMonth + " " + RTC.Hour + ":" + RTC.Minute);
            c.DrawString((int)Kernel.ScreenWidth / 2 - timeWidth / 2, 4, RTC.Year + "/" + RTC.Month + "/" + RTC.DayOfTheMonth + " " + RTC.Hour + ":" + RTC.Minute, Kernel.font, ThemeManager.GetCurrentTheme().ForeColor);
            // draw dock
            c.DrawFilledRectangle(0, (int)Kernel.ScreenHeight - 40, (int)Kernel.ScreenWidth, 40, 0, ThemeManager.GetCurrentTheme().BackColor);
            c.DrawString(4, (int)Kernel.ScreenHeight - 60, Kernel._fps + " FPS", Kernel.font, ThemeManager.GetCurrentTheme().ForeColor);
            //desktopTextView.Draw(c);
            openOSVersion.Draw(c);
            shutdown.Draw(c);
            reboot.Draw(c);
            consolemode.Draw(c);
            openUILibrary.Draw(c);
            openSipad.Draw(c);
            openFileExplorer.Draw(c);
            //window.Draw(c);
            exButton.Draw(c);
        }

        internal override void Update()
        {
            openOSVersion.Update();
            openUILibrary.Update();
            shutdown.Update();
            reboot.Update();
            consolemode.Update();
            openSipad.Update();
            openFileExplorer.Update();
            //window.Update();
            exButton.Update();
            if (openOSVersion.ButtonState == ButtonState.Clicked)
            {
                Kernel.OpenApplication(new OSVer());
            }
            if (openSipad.ButtonState == ButtonState.Clicked)
            {
                Kernel.OpenApplication(new Spad());
            }
            if (openUILibrary.ButtonState == ButtonState.Clicked)
            {
                Kernel.OpenApplication(new UILib());
            }
            if (shutdown.ButtonState == ButtonState.Clicked)
            {
                Sys.Power.Shutdown();
            }
            if (reboot.ButtonState == ButtonState.Clicked)
            {
                Sys.Power.Reboot();
            }
            if (openFileExplorer.ButtonState == ButtonState.Clicked)
            {
                Kernel.OpenApplication(new FileEx());
            }
            if (consolemode.ButtonState == ButtonState.Clicked)
            {
                Kernel.ConsoleMode();
                Shell.GetInput();
                return;
            }
            if (exButton.ButtonState == ButtonState.Clicked)
            {
                throw new System.Exception("UserException");
                return;
            }
        }
    }
}