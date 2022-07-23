using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SipaaKernelV2.Commands;
namespace SipaaKernelV2
{
    public class Shell
    {
        public static List<Command> cmds = new List<Command>();

        internal static void LoadCommands()
        {
            Console.WriteLine("SipaaKernel V2");
            cmds.Add(new CrashCommand());
        }

        internal static void GetInput()
        {
            Console.Write("shell:>");

            string input = Console.ReadLine();
            string[] pos = input.Split(' ');
            bool exec = false;
            List<string> cmdArgs;

            // Add args into a list
            cmdArgs = new List<string>();
            foreach (string arg in pos)
            {
                cmdArgs.Add(arg);
            }
            // Remove the command name
            cmdArgs.Remove(cmdArgs[0]);

            // Find and execute the command
            for (int i = 0; i < cmds.Count; i++)
            {
                for (int j = 0; j < cmds[i].names.Length; j++)
                {
                    if (pos[0].ToLower() == cmds[i].names[j])
                    {
                        exec = true;
                        var result = cmds[i].Execute(cmdArgs);
                        if (result == CommandResult.Error)
                        {
                            Console.WriteLine("Error occured during the command execution.");
                        }
                        else if (result == CommandResult.InvalidArgs)
                        {
                            Console.WriteLine("Invalid arguments");
                        }else if (result == CommandResult.Fatal)
                        {
                            throw new Exception("Fatal error occured during command execution.");
                        }
                    }
                }
            }

            if (!exec) { Console.WriteLine("Invalid command!", ConsoleColor.Red); }

            GetInput();
        }
    }

    public enum CommandResult
    {
        Sucess,
        Error,
        InvalidArgs,
        Fatal
    }

    public abstract class Command
    {
        public string[] names;
        public string Description;

        public abstract CommandResult Execute(List<string> args);
    }
}
