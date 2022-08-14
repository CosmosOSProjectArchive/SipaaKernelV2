using Cosmos.System.Graphics;
using SipaaKernelV2.Core.Graphics;
using System;
using System.Collections.Generic;

namespace SipaaKernelV2.UI
{
    public abstract class View
    {
        internal string ViewName;
        internal List<Control> controls;
        internal abstract void Update();

        internal abstract void Draw(FrameBuffer c);
        internal virtual void OnViewOpened() { }
    }
}