using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.System.Graphics;
namespace SipaaKernelV2
{
    internal class Application
    {
        public View CurrentView;
        public string ApplicationName, ApplicationDeveloper;
        public double ApplicationVersion;

        public void SetCurrentView(View view)
        {
            if (view == null) return;
            CurrentView = view;
        }

        public void Update()
        {
            CurrentView.Update();
        }
        public void Draw(Canvas c)
        {
            CurrentView.Draw(c);
        }

        public void OnMessage(Message msg, object args)
        {
            CurrentView.OnMessage(msg, args);
        }
    }
}
