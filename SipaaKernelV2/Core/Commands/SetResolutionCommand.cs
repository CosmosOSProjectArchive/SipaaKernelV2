using Cosmos.Core;
using SipaaKernelV2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipaaKernelV2.Core.Commands
{
    internal class SetResolutionCommand : Command
    {
        public SetResolutionCommand()
        {
            this.names = new string[] { "setresolution", "setres" };
            this.Description = "Sets the resolution of the GUI canvas.";
            this.usages = new string[] { "setresolution [width] [height]", "setres [width] [height]" };
        }
        public override CommandResult Execute(List<string> args)
        {
            try
            {
                if (args.Count == 2)
                {
                    /**uint width = uint.Parse(args[0]);
                    uint height = uint.Parse(args[1]); 
                    VBE.getModeInfo().
                    Kernel.ScreenWidth = VBE.getModeInfo().width;
                    Kernel.ScreenHeight = VBE.getModeInfo().height;
                    Cosmos.HAL.Global.PIT.Wait(1200);**/
                    Console.WriteLine("Sorry, you can't change the resolution with current driver.");
                    return CommandResult.Sucess;
                }
                else
                {

                    return CommandResult.InvalidArgs;
                }
            }catch (Exception ex)
            {
                return CommandResult.Fatal;
            }
        }
    }
}
