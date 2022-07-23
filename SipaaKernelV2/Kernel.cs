using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;
using Cosmos.HAL;
using Cosmos.Core.Memory;
using SipaaKernelV2.UI;
using System;

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
        public static TextView helloWorldTextView;
        public static byte _deltaT;
        public static bool Pressed;
        public static object FreeCount;
        public static int _fps;
        public static int _frames;

        protected override void BeforeRun()
        {
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

            shutdownBtn = new Button("Shutdown", 8, 8 + (uint)font.Height * 2);
            helloWorldTextView = new TextView("Hello world on a TextView!", 8, 8 + (uint)font.Height * 2 + shutdownBtn.Height);

            GUIMode = true;
        }
        public static void DrawDebug()
        {
            int x = 8;
            int y = 8;
            Pen whitePen = ColorPens.whitePen;
            c.DrawString(_fps + " FPS", font, whitePen, x, y);
            c.DrawString("SipaaKernel v2 (Alpha)", font, whitePen, x, y + font.Height);
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

                    c.DrawFilledRectangle(ColorPens.blackPen, new Point(0, 0), (int)ScreenWidth, (int)ScreenHeight);

                    DrawDebug();

                    shutdownBtn.Draw(c);
                    helloWorldTextView.Draw(c);
                    shutdownBtn.Update();

                    if (shutdownBtn.Click)
                    {
                        Sys.Power.Shutdown();
                    }
                    c.DrawFilledRectangle(ColorPens.whitePen, (int)Sys.MouseManager.X, (int)Sys.MouseManager.Y, 12, 8);

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
