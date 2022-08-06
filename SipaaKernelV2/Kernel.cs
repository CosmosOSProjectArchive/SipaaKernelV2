using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;
using Cosmos.HAL;
using Cosmos.Core.Memory;
using SipaaKernelV2.UI;
using System;
using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using SipaaKernelV2.Applications.SipaaDesktop;
using SipaaKernelV2.Applications.OSVersion;

namespace SipaaKernelV2
{
    public class Kernel : Sys.Kernel
    {
        public static Canvas c;
        public static Font font = PCScreenFont.Default;
        public const string OSName = "SipaaKernel V2 Pre-Release 1";
        public const double OSVersion = 22.2, OSBuild = 1001.254;
        public static uint
            ScreenWidth = 1280,
            ScreenHeight = 720;
        public static bool GUIMode = false;
        internal static Application[] apps = new Application[] { new SipaaDesktop(), new OSVersion() };
        internal static Application CurrentApplication = apps[0];
        public static byte _deltaT;
        public static bool Pressed;
        public static object FreeCount;
        public static int _fps;
        public static int _frames;
        public static CosmosVFS vfs;
        public static Bitmap cursor = new Bitmap(Files.Cursor);
        public static Bitmap wallpaper = new Bitmap(Files.Wallpaper);
        public static Bitmap logo = new Bitmap(Files.OSLogo);

        protected override void OnBoot()
        {
            try
            {
                Console.WriteLine("Starting SipaaKernel...");
                Cosmos.HAL.Global.PIT.Wait(2000);
                base.OnBoot();
            }
            catch (Exception ex)
            {
                CrashScreen.DisplayKernelErrorAndReboot(ex.Message);
            }
        }

        protected override void BeforeRun()
        {
            Console.WriteLine("Initializing Filesystem...");
            vfs = new CosmosVFS();
            VFSManager.RegisterVFS(vfs);
            Console.Clear();
            Shell.LoadCommands();
        }

        internal static void OpenApplication(Application app)
        {
            if (app == null) return;
            CurrentApplication = app;
        }

        public static void ConsoleMode()
        {
            c.Disable();
            GUIMode = false;
        }

        public static void GoToGUIMode()
        {
            c = FullScreenCanvas.GetFullScreenCanvas(new Mode((int)ScreenWidth, (int)ScreenHeight, ColorDepth.ColorDepth32));
            Sys.MouseManager.ScreenWidth = ScreenWidth;
            Sys.MouseManager.ScreenHeight = ScreenHeight;

            GUIMode = true;
        }

        protected override void Run()
        {
            try
            {
                if (GUIMode)
                {
                    if (_deltaT != RTC.Second)
                    {
                        _fps = _frames;
                        _frames = 0;
                        _deltaT = RTC.Second;
                    }

                    _frames++;

                    FreeCount = Heap.Collect();

                    switch (Sys.MouseManager.MouseState)
                    {
                        case Sys.MouseState.Left:
                            Pressed = true;
                            break;
                        case Sys.MouseState.None:
                            Pressed = false;
                            break;
                    }

                    if (CurrentApplication != null)
                    {
                        CurrentApplication.Draw(c);
                        CurrentApplication.Update();
                    }

                    c.DrawImageAlpha(cursor, (int)Sys.MouseManager.X, (int)Sys.MouseManager.Y);

                    c.Display();
                }
                else
                {
                    Shell.GetInput();
                }
            }
            catch (Exception ex)
            {
                CrashScreen.DisplayAndReboot(ex.Message);
            }
        }
    }
}
