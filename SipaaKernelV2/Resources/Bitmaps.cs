using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SipaaKernelV2.Core;
using SipaaKernelV2.Core.Graphics;

namespace SipaaKernelV2
{
    internal class Bitmaps
    {
        public static FrameBuffer cursor = Bitmap.FromBitmap(Files.Cursor);
        public static FrameBuffer wallpaper = Bitmap.FromBitmap(Files.Wallpaper);
        public static FrameBuffer logo = Bitmap.FromBitmap(Files.OSLogo);
        public static FrameBuffer checkbox = Bitmap.FromBitmap(Files.CheckBox);
        public static FrameBuffer checkedcheckbox = Bitmap.FromBitmap(Files.CheckedCheckBox);
        public static FrameBuffer error = Bitmap.FromBitmap(Files.Error);
        public static FrameBuffer file = Bitmap.FromBitmap(Files.File);
        public static FrameBuffer folder = Bitmap.FromBitmap(Files.Folder);
        public static FrameBuffer about = Bitmap.FromBitmap(Files.AboutOS);
        public static FrameBuffer sipad = Bitmap.FromBitmap(Files.Sipad);
        public static FrameBuffer uilib = Bitmap.FromBitmap(Files.UILibrary);
        public static FrameBuffer ssd = Bitmap.FromBitmap(Files.SSD);
        public static FrameBuffer throwex = Bitmap.FromBitmap(Files.ThrowException);
        public static FrameBuffer shutdown = Bitmap.FromBitmap(Files.Shutdown);
        public static FrameBuffer reboot = Bitmap.FromBitmap(Files.Reboot);
        public static FrameBuffer consolemode = Bitmap.FromBitmap(Files.ConsoleMode);
    }
}
