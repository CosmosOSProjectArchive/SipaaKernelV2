using SipaaKernelV2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipaaKernelV2.Applications.UIGallery
{
    internal class UIGallery : Application
    {
        public UIGallery()
        {
            ApplicationName = "SipaaPaint";
            ApplicationDeveloper = "RaphMar2019";
            ApplicationVersion = 1.0;
            SetCurrentView(new UIGalleryView());
        }
    }
}
