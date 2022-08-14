using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using Cosmos.HAL;
using Cosmos.Core.Memory;
using SipaaKernelV2.UI;
using System;
using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using SipaaKernelV2.Applications.SipaaDesktop;
using SipaaKernelV2.Applications.OSVersion;
using SipaaKernelV2.Core;
using SipaaKernelV2.Applications.Sipad;
using SipaaKernelV2.Applications.UIGallery;
using SipaaKernelV2.Core.Translations;
using SipaaKernelV2.Core.FileSystem;
using SipaaKernelV2.Core.Keyboard;
using SipaaKernelV2.Applications.BootScreen;
using SipaaKernelV2.Applications.FileExplorer;
using SipaaKernelV2.Applications.CrashScreen;
using SipaaKernelV2.UI.SysTheme;
using SipaaKernelV2.Core.Graphics;
using Cosmos.Core;

namespace SipaaKernelV2
{
    public unsafe class Kernel : Sys.Kernel
    {
        public static FrameBuffer f;
        public static Font font = Font.Default;
        public const string OSName = "SipaaKernel V2 Developer Beta";
        public const double OSVersion = 22.09, OSBuild = 1154.500;
        public const bool IsDeveloperBeta = true;
        public static uint
            ScreenWidth = VBE.getModeInfo().width,
            ScreenHeight = VBE.getModeInfo().height;
        public static bool GUIMode = false;
        internal static Application CurrentApplication = new SipaaDesktop();
        public static byte _deltaT;
        public static bool Pressed;
        public static object FreeCount;
        public static int _fps;
        public static int _frames;
        public static CosmosVFS vfs;
        public static LanguageBase language = new EnglishLang();
        public static bool booting;
        public static int bootprogress;

        protected override void OnBoot()
        {
            try
            {
                base.OnBoot();
            }
            catch (Exception ex)
            {
                CrashScreen.DisplayKernelErrorAndReboot(ex.Message);
            }
        }

        protected override void BeforeRun()
        {
            OpenApplication(new BootApp());
            GoToGUIMode();
            if (!FSDriver.Initialize())
                Console.WriteLine("Cannot init filesystem!");
            booting = true;
        }

        internal static void OpenApplication(Application app)
        {
            if (app == null) return;
            CurrentApplication = app;
        }

        public static void ConsoleMode()
        {
            f.Dispose();
            GUIMode = false;
            if (!Shell.LoadedCommands)
                Shell.LoadCommands();
        }

        public static void GoToGUIMode()
        {
            f = new(VBE.getModeInfo().width, VBE.getModeInfo().height);
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

                    if (booting)
                    {
                        bootprogress++;
                        if (CurrentApplication != null)
                        {
                            CurrentApplication.Draw(f);
                            CurrentApplication.Update();
                        }
                        if (bootprogress == 250)
                        {
                            booting = false;
                            OpenApplication(new SipaaDesktop());
                        }
                    }
                    else
                    {
                        KBPS2.Update();
                        if (CurrentApplication != null)
                        {
                            CurrentApplication.Draw(f);
                            CurrentApplication.Update();
                        } 
                        f.DrawImage((int)Sys.MouseManager.X, (int)Sys.MouseManager.Y, Bitmaps.cursor, true);
                    }
                }
                else
                {
                    Shell.GetInput();
                }
                f.CopyTo((uint*)VBE.getLfbOffset());
            }
            catch (Exception ex)
            {
                if (GUIMode) 
                    OpenApplication(new CrashApp(ex));
                else
                    CrashScreen.DisplayAndReboot(ex.Message);
            }
        }
    }
}
