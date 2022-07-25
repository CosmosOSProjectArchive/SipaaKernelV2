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
    public class TextView : Control
    {
        private string text = "Button";
        private Color textColor = Color.White;

        public string Text { get { return text; } set { text = value; } }

        public Color TextColor { get { return textColor; } set { textColor = value; } }

        public TextView(string text, uint x, uint y)
        {
            this.text = text;
            this.X = x;
            this.Y = y;
        }

        public override void Draw(Canvas c)
        {
            c.DrawString(Text, PCScreenFont.Default, new Pen(TextColor), (int)X, (int)Y);
        }
    }
}
