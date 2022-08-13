using SipaaKernelV2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipaaKernelV2.Applications.Sipad
{
    internal class Sipad : Application
    {
        public Sipad()
        {
            ApplicationName = "Sipad App";
            ApplicationDeveloper = "RaphMar2019";
            ApplicationVersion = 1.0;
            SetCurrentView(new SipadView());
        }
    }
}
