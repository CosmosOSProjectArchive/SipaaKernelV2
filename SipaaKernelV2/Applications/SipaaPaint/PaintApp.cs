using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipaaKernelV2.Applications.SipaaPaint
{
    internal class PaintApp : Application
    {
        public PaintApp()
        {
            ApplicationName = "SipaaPaint";
            ApplicationDeveloper = "RaphMar2019";
            ApplicationVersion = 1.0;
            SetCurrentView(new PaintView());
        }
    }
}
