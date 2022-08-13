using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SipaaKernelV2.Core;

namespace SipaaKernelV2.Applications.BootScreen
{
    internal class BootApp : Application
    {
        public BootApp()
        {
            this.ApplicationName = "Boot Screen App";
            this.ApplicationDeveloper = "RaphMar2019";
            this.ApplicationVersion = 1.0;
            this.SetCurrentView(new BootView());
        }
    }
}
