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
    public class TextBox : Control
    {
        // Fields, properties and constructors
        private string text = "";
        private uint width = 150, height = 40;
        private bool focus = false;
        private bool multiline = false;

        public string Text { get { return text; } }
        public bool Focus { get { return focus; } set { focus = value; } }
        public uint Width { get { return width; } set { width = value; } }
        public uint Height { get { return height; } set { height = value; } }
        public bool Multiline { get => multiline; set => multiline = value; }

        public TextBox(uint x, uint y)
        {
            this.X = x;
            this.Y = y;
        }

        public override void Draw(Canvas c)
        {
            c.DrawFilledRectangle(ColorPens.idleButtonPen, (int)X, (int)Y, (int)width, (int)height);
            c.DrawRectangle(ColorPens.lightGrayPen, (int)X, (int)Y, (int)width, (int)height);
            // Draw text under the button
            c.DrawString(Text, PCScreenFont.Default, ColorPens.whitePen, (int)this.X + 4, (int)this.Y + (int)this.Height / 2 - (int)PCScreenFont.Default.Height / 2);
        }

        public override void Update()
        {
            if (MouseManager.X > X && MouseManager.X < X + Width && MouseManager.Y > Y && MouseManager.Y < Y + Height)
            {
                if (MouseManager.MouseState == MouseState.Left)
                {
                    focus = true;
                }
            }

            if (focus)
            {
                KeyEvent e = KeyboardManager.ReadKey();
                if (e.Key == ConsoleKeyEx.Escape)
                {
                    focus = false;
                    return;
                }else if (e.Key == ConsoleKeyEx.Backspace)
                {
                    text.Substring(text.Length - 1, 1);
                }else if (e.Key == ConsoleKeyEx.Enter)
                {
                    if (multiline)
                    {
                        text += "\n\r";
                    }
                }
                else if (e.Key == ConsoleKeyEx.Tab)
                {
                    text += "    ";
                }
                else
                {
                    text += e.KeyChar;
                }
            }
        }
    }
}
