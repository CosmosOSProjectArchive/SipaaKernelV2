using SipaaKernelV2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipaaKernelV2.Applications.OSVersion
{
    internal class OSVersion : Application
    {
        public OSVersion()
        {
            ApplicationName = "SipaaKernel Version App";
            ApplicationDeveloper = "RaphMar2019";
            ApplicationVersion = 1.0;
            SetCurrentView(new OSVersionView());
        }
    }
}
