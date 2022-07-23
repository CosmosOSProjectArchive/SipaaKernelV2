using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipaaKernelV2.Commands
{
    internal class SetResolutionCommand : Command
    {
        public SetResolutionCommand()
        {
            this.names = new string[] { "setresolution" };
        }
        public override CommandResult Execute(List<string> args)
        {
            try
            {

                return CommandResult.Sucess;
            }catch (Exception ex)
            {
                return CommandResult.Fatal;
            }
        }
    }
}
