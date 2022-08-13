using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;

namespace SipaaKernelV2.UI
{
    public abstract class View
    {
        internal string ViewName;
        internal List<Control> controls;
        internal abstract void Update();

        internal abstract void Draw(Canvas c);
        internal virtual void OnViewOpened() { }
    }
}