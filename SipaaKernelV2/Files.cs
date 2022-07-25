using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IL2CPU.API.Attribs;
namespace SipaaKernelV2
{
    internal class Files
    {
        [ManifestResourceStream(ResourceName = "SipaaKernelV2.Resources.pointer.bmp")]
        public static byte[] Cursor; 
        [ManifestResourceStream(ResourceName = "SipaaKernelV2.Resources.Wallpaper.bmp")]
        public static byte[] Wallpaper;
    }
}
