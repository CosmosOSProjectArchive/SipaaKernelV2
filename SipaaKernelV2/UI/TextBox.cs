using Cosmos.System;
using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;
using SipaaKernelV2.Core.Graphics;
using SipaaKernelV2.Core.Keyboard;
using SipaaKernelV2.UI.SysTheme;
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
        private ThemeBase theme = ThemeManager.GetCurrentTheme();
        private KBStringReader r;
        private byte tick;
        private byte prevSec;
        private bool cursor;
        private bool passwordFilter;
        private int textW;

        public string Text { get { return text; } }
        public bool Focus { get { return focus; } set { focus = value; } }
        public uint Width { get { return width; } set { width = value; } }
        public uint Height { get { return height; } set { height = value; } }
        public bool Multiline { get => multiline; set { multiline = value; r.acceptNewLine = value; } }
        public bool PasswordFilter { get => passwordFilter; set => passwordFilter = value; }
        public ThemeBase Theme { get { return theme; } set { theme = value; } }

        public TextBox(uint x, uint y)
        {
            r = new KBStringReader();
            this.X = x;
            this.Y = y;
        }

        public override void Draw(FrameBuffer c)
        {
            c.DrawFilledRectangle((int)X, (int)Y, (int)width, (int)height, 0, theme.BackColor);

            if (theme.BorderSize > 1)
            {
                c.DrawRectangle((int)X, (int)Y, (int)width, (int)height, 0,theme.BorderColor);
            }
            if (text.Length > 0)
            {
                if (!passwordFilter && multiline)
                {
                    c.DrawString((int)X + 4, (int)Y + 4, text, Kernel.font, theme.ForeColor);
                }
                else if (!passwordFilter) 
                {
                    c.DrawString((int)X + 4, (int)Y + ((int)height / 2) - 4, text,Kernel.font,theme.ForeColor); 
                }
                /**else if (passwordFilter && multiline)
                {
                    int sx = (int)X + 4;
                    for (int i = 0; i < text.Length; i++)
                    {
                        c.DrawChar(sx, (int)Y + 4, '*', Kernel.font, theme.ForeColor, false);
                        sx += Kernel.font.Width;
                    }
                }
                else if (passwordFilter)
                {
                    int sx = (int)X + 4;
                    for (int i = 0; i < text.Length; i++)
                    {
                        c.DrawChar(sx, (int)Y + 4, '*', Kernel.font, theme.ForeColor, false);
                        sx += Kernel.font.Width;
                    }
                }**/
            }
            
        }

        public override void Update()
        {
            textW = (int)Kernel.font.MeasureString(text);
            if (textW < 0) { textW = 0; }

            if (MouseManager.X > X && MouseManager.X < X + Width && MouseManager.Y > Y && MouseManager.Y < Y + Height)
            {
                if (MouseManager.MouseState == MouseState.Left)
                {
                    focus = true;
                }
            }


            // when focused
            if (focus)
            {
                if (KBPS2.IsKeyDown(ConsoleKeyEx.Escape)) { focus = false; }
                else
                {
                    tick = Cosmos.HAL.RTC.Second;
                    if (tick != prevSec)
                    {
                        cursor = !cursor;
                        prevSec = tick;
                    }
                    r.GetInput();
                    text = r.output;
                }
            }
        }
    }
}
