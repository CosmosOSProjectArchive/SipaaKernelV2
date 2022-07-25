using System;

namespace SipaaKernelV2
{
    internal class CrashScreen
    {
        internal static void DisplayAndReboot(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("  :(");
            Console.WriteLine();
            Console.WriteLine("  Your device ran into a problem and needs to restart.");
            Console.WriteLine();
            Console.WriteLine("  " + message);
            Console.WriteLine();
            Console.WriteLine("  If this is the first time you see this error, reboot.");
            Console.WriteLine("  Else, report this bug to the SipaaKernelV2 Github");
            Console.WriteLine("  repository.");
            Console.WriteLine();
            Console.WriteLine("  Press any key to reboot.");
            Console.ReadKey();
            Cosmos.System.Power.Reboot();
        }
        internal static void DisplayKernelErrorAndReboot(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("  The Sipaa Kernel encountered an error.");
            Console.WriteLine();
            Console.WriteLine("  " + message);
            Console.WriteLine();
            Console.WriteLine("  If this is the first time you see this error, reboot.");
            Console.WriteLine("  Else, report this bug to the SipaaKernelV2 Github");
            Console.WriteLine("  repository.");
            Console.WriteLine();
            Console.WriteLine("  Press any key to reboot.");
            Console.ReadKey();
            Cosmos.System.Power.Reboot();
        }
    }
}