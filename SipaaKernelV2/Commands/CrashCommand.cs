using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipaaKernelV2.Commands
{
    internal class CrashCommand : Command
    {
        public CrashCommand()
        {
            this.names = new string[] { "crash" };
            this.Description = "Crashes SipaaKernel.";
        }
        public override CommandResult Execute(List<string> args)
        {
            throw new Exception("User manually throw this exception.");
        }
    }
}
