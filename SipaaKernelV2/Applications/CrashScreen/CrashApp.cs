using SipaaKernelV2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipaaKernelV2.Applications.CrashScreen
{
    internal class CrashApp : Application
    {
        public CrashApp(Exception ex)
        {
            ApplicationName = "SipaaKernel crash screen application";
            ApplicationDeveloper = "RaphMar2019";
            ApplicationVersion = 1.0;
            SetCurrentView(new CrashScreenView(ex));
        }
    }
}
