using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;
using Cosmos.HAL;
using Cosmos.Core.Memory;
using SipaaKernelV2.UI;
using System;
using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;

namespace SipaaKernelV2
{
    public class Kernel : Sys.Kernel
    {
        public static Canvas c;
        public static Font font = PCScreenFont.Default;
        public static uint
            ScreenWidth = 1280,
            ScreenHeight = 720;
        public static bool GUIMode = false;
        public static Button shutdownBtn;
        public static Button consoleModeBtn;
        public static TextView helloWorldTextView;
        public static byte _deltaT;
        public static bool Pressed;
        public static object FreeCount;
        public static int _fps;
        public static int _frames;
        public static CosmosVFS vfs;
        public static Bitmap cursor = new Bitmap(Files.Cursor);
        public static Bitmap wallpaper = new Bitmap(Files.Wallpaper);

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

            shutdownBtn = new Button("Shutdown", 8, ScreenHeight - 48, 150, 48);
            consoleModeBtn = new Button("Console mode", 158, ScreenHeight - 48, 150, 48);
            helloWorldTextView = new TextView("Hello world on a TextView!", 8, 8 + (uint)font.Height * 2 + 2);

            GUIMode = true;
        }
        public static void DrawDebug()
        {
            int x = 8;
            int y = 8;
            Pen whitePen = ColorPens.whitePen;
            c.DrawString(_fps + " FPS", font, whitePen, x, y);
            c.DrawString("SipaaKernel v2 (Beta)", font, whitePen, x, y + font.Height);
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

                    c.DrawImage(wallpaper, 0, 0);

                    DrawDebug();

                    c.DrawFilledRectangle(ColorPens.whitePen, new Point(0, (int)ScreenHeight - 48), (int)ScreenWidth, 48);

                    shutdownBtn.Draw(c);
                    consoleModeBtn.Draw(c);
                    helloWorldTextView.Draw(c);
                    shutdownBtn.Update();
                    consoleModeBtn.Update();

                    if (shutdownBtn.Click)
                    {
                        Sys.Power.Shutdown();
                    }
                    if (consoleModeBtn.Click)
                    {
                        ConsoleMode();
                        return;
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
