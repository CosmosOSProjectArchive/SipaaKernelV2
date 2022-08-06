using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipaaKernelV2.UI
{
    public class Panel : Control
    {
        private uint width = 150, height = 150;
        private bool visible = false;
        private List<Control> controls = new List<Control>();

        public List<Control> Controls { get { return controls; } set { controls = value; } }
        public uint Width { get { return width; } set { width = value; } }
        public uint Height { get { return height; } set { height = value; } }

        public bool Visible { get => visible; set => visible = value; }

        public Panel(uint x, uint y, uint width, uint height)
        {
            this.X = x;
            this.Y = y;
            this.width = width;
            this.height = height;
        }

        public override void Draw(Canvas c)
        {
            // Verify if the panel is visible
            if (Visible)
            {
                c.DrawRectangle(ColorPens.whitePen, X, Y, Width, Height); // Draw panel rectangle

                foreach (Control ctrl in Controls)
                {
                    ctrl.Draw(c);
                }
            }
        }

        public override void Update()
        { 
            // Verify if the panel is visible
            if (Visible)
            {
                foreach (Control ctrl in Controls)
                {
                    ctrl.Update();
                }
            }
        }
    }
}
