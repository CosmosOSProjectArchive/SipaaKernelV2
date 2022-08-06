using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using SipaaKernelV2.UI;
namespace SipaaKernelV2
{
    public abstract class View
    {
        internal string ViewName;
        internal List<Control> controls;
        internal abstract void Update();

        internal abstract void Draw(Canvas c);

        internal void OnMessage(Message msg, object args)
        {
            foreach (Control c in controls)
            {
                c.OnMessage(msg, args);
            }
        }
    }
}