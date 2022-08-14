using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;
using SipaaKernelV2.Core.Keyboard;
using SipaaKernelV2.Core.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipaaKernelV2.UI
{
    public class TextView : Control
    {
        private string text = "Hello, world!";
        private Color textColor = Color.White;

        public string Text { get { return text; } set { text = value; } }

        public Color TextColor { get { return textColor; } set { textColor = value; } }

        public TextView(string text, uint x, uint y)
        {
            this.text = text;
            this.X = x;
            this.Y = y;
        }

        public override void Draw(FrameBuffer c)
        {
            c.DrawString((int)X, (int)Y, Text, Kernel.font, TextColor);
        }
    }
}
