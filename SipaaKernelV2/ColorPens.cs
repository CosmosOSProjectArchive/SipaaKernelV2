using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using g = Cosmos.System.Graphics;
namespace SipaaKernelV2
{
    public class ColorPens
    {
        public static Pen
            whitePen = new g.Pen(Color.White),
            lightGrayPen = new g.Pen(Color.LightGray),
            blackPen = new g.Pen(Color.Black);
    }
}
