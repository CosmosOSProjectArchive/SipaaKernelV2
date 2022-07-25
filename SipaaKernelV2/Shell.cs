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
        public static string CurrentDir = @"0:\";

        internal static void LoadCommands()
        {
            Console.WriteLine("SipaaKernel V2");
            Console.WriteLine("Type help to get all commands.");
            cmds.Add(new CrashCommand());
            cmds.Add(new SetResolutionCommand());
            cmds.Add(new GUICommand());
            cmds.Add(new HelpCommand());
            cmds.Add(new DiskCommand());
        }

        internal static Command GetCommand(string command)
        {
            for (int i = 0; i < cmds.Count; i++)
            {
                for (int j = 0; j < cmds[i].names.Length; j++)
                {
                    if (command.ToLower() == cmds[i].names[j])
                    {
                        return cmds[i];
                    }
                }
            }
            return null;
        }

        internal static void GetInput()
        {
            Console.WriteLine();
            Console.Write("shell@" + CurrentDir + ":>");
            string input = Console.ReadLine();
            Console.WriteLine();
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
                        }else if (result == CommandResult.ExitGetInput)
                        {
                            return;
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
        Fatal,
        ExitGetInput
    }

    public abstract class Command
    {
        public string[] names;
        public string[] usages;
        public string Description;

        public abstract CommandResult Execute(List<string> args);
    }
}
