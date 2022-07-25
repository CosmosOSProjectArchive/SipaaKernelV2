using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipaaKernelV2.Commands
{
    internal class HelpCommand : Command
    {
        public HelpCommand()
        {
            this.names = new string[] { "help" };
            this.Description = "Show all commands / Show command infos";
            this.usages = new string[] { "help", "help [command]" };
        }

        public override CommandResult Execute(List<string> args)
        {
            if (args.Count == 0)
            {
                Console.WriteLine("All commands :");
                Console.WriteLine("help-----------Show all commands / Show command infos");
                Console.WriteLine("gui------------Go to GUI mode of SipaaKernel");
                Console.WriteLine("setres---------Sets the resolution of the GUI canvas.");
                Console.WriteLine("crash----------Crashes SipaaKernel");
                return CommandResult.Sucess;
            }
            else if (args.Count == 1)
            {
                Command cmd = new HelpCommand();
                if (cmd != null)
                {
                    string cmdnames = "";
                    foreach (string name in cmd.names)
                    {
                        cmdnames += name + " ";
                    }
                    Console.WriteLine("Name(s) : " + cmdnames);
                    Console.WriteLine("Description : " + cmd.Description);
                    Console.WriteLine("Usages :");
                    foreach (string usage in cmd.usages)
                    {
                        Console.WriteLine("  " + usage);
                    }
                    return CommandResult.Sucess;
                }
                else
                {
                    return CommandResult.Error;
                }
            }
            else
            {
                return CommandResult.InvalidArgs;
            }
        }
    }
}
