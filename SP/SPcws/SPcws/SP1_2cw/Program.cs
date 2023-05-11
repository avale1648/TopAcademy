using System;
using System.Diagnostics;
namespace SP1_2cw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();
            process.StartInfo.FileName = "notepad.exe";
            process.Start();
            Console.WriteLine($"Process was launched: {process.ProcessName}");
            process.WaitForExit();
            Console.WriteLine($"Process {process} was ended with code {process.ExitCode}");
            Console.WriteLine($"Current process: {Process.GetCurrentProcess().ProcessName}");
        }
    }
}
