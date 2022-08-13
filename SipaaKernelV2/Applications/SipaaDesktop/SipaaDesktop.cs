using SipaaKernelV2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipaaKernelV2.Applications.SipaaDesktop
{
    internal class SipaaDesktop : Application
    {
        public SipaaDesktop()
        {
            ApplicationName = "SipaaDesktop";
            ApplicationDeveloper = "RaphMar2019";
            ApplicationVersion = 1.0;
            SetCurrentView(new DesktopView());
        }
    }
}
