using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipaaKernelV2.Core.Graphics
{
    public static unsafe class Bitmap
    {
        public static FrameBuffer FromBitmap(byte[] Binary)
        {
            Cosmos.System.Graphics.Bitmap BMP = new(Binary);
            fixed (uint* PTR = (uint[])(object)BMP.rawData)
            {
                return new FrameBuffer(BMP.Width, BMP.Height) { Internal = PTR };
            }
        }
    }
}
