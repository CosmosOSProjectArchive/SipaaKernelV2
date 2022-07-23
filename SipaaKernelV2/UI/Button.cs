using Cosmos.System;
using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipaaKernelV2.UI
{
    public class Button
    {
        // Fields, properties and constructors
        private string text = "Button";
        private uint x = 0, y = 0, width = 150, height = 40;
        private bool click;

        public string Text { get { return text; } set { text = value; } }

        public uint X { get { return x; } set { x = value; } }
        public uint Y { get { return y; } set { y = value; } }
        public uint Width { get { return width; } set { width = value; } }
        public uint Height { get { return height; } set { height = value; } }
        public bool Click { get { return click; } }
        public Button(string text, uint x, uint y, uint width, uint height)
        {
            this.text = text;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        public Button(string text, uint x, uint y)
        {
            this.text = text;
            this.x = x;
            this.y = y;
        }

        public void Draw(Canvas c)
        {
            // Draw button rectangle 
            c.DrawFilledRectangle(ColorPens.whitePen, (int)X, (int)Y, (int)width, (int)height);
            c.DrawRectangle(ColorPens.lightGrayPen, (int)X, (int)Y, (int)width, (int)height);
            // Draw text under the button
            c.DrawString(Text, PCScreenFont.Default, ColorPens.blackPen, (int)this.X + 4, (int)this.Y + (int)this.Height / 2 - (int)PCScreenFont.Default.Height / 2);
        }

        public void Update()
        {
            if (MouseManager.MouseState == MouseState.Left)
            {
                if (MouseManager.X > X && MouseManager.X < X + Width && MouseManager.Y > Y && MouseManager.Y < Y + Height)
                {
                    click = true;
                }
            }
        }
    }
}
