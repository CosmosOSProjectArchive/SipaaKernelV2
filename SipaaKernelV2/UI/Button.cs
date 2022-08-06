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
    public class Button : Control
    {
        // Fields, properties and constructors
        private string text = "Button";
        private uint width = 150, height = 40;
        private ButtonState state;

        public string Text { get { return text; } set { text = value; } }

        public uint Width { get { return width; } set { width = value; } }
        public uint Height { get { return height; } set { height = value; } }
        public ButtonState ButtonState { get { return state; } }
        public Button(string text, uint x, uint y, uint width, uint height)
        {
            this.text = text;
            this.X = x;
            this.Y = y;
            this.width = width;
            this.height = height;
        }
        public Button(string text, uint x, uint y)
        {
            this.text = text;
            this.X = x;
            this.Y = y;
        }

        public override void Draw(Canvas c)
        {
            // Draw button rectangle 
            switch (this.state)
            {
                case ButtonState.Idle:
                    c.DrawFilledRectangle(ColorPens.idleButtonPen, (int)X, (int)Y, (int)width, (int)height);
                    break;
                case ButtonState.Hover:
                    c.DrawFilledRectangle(ColorPens.hoverButtonPen, (int)X, (int)Y, (int)width, (int)height);
                    break;
                case ButtonState.Clicked:
                    c.DrawFilledRectangle(ColorPens.clickedButtonPen, (int)X, (int)Y, (int)width, (int)height);
                    break;
            }
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
                    state = ButtonState.Clicked;
                }
                else
                {
                    state = ButtonState.Hover;
                }
            }
            else
            {
                state = ButtonState.Idle;
            }
        }
    }
}
