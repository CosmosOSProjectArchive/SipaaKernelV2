﻿using System;
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
                    uint width = uint.Parse(args[0]);
                    uint height = uint.Parse(args[1]);
                    Kernel.ScreenWidth = width;
                    Kernel.ScreenHeight = height;
                    Console.WriteLine("Changes will be applied when you restart GUI.");
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
