using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipaaKernelV2.UI
{
    public class TextView
    {
        private string text = "Button";
        private uint x = 0, y = 0;
        private Color textColor = Color.White;

        public string Text { get { return text; } set { text = value; } }

        public Color TextColor { get { return textColor; } set { textColor = value; } }

        public uint X { get { return x; } set { x = value; } }
        public uint Y { get { return y; } set { y = value; } }

        public TextView(string text, uint x, uint y)
        {
            this.text = text;
            this.x = x;
            this.y = y;
        }

        public void Draw(Canvas c)
        {
            c.DrawString(Text, PCScreenFont.Default, new Pen(TextColor), (int)X, (int)Y);
        }
    }
}
