using System;
using System.Diagnostics;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter seconds : ");
            int minutes = int.Parse(Console.ReadLine());

            ProcessStartInfo processStartInfo = new ProcessStartInfo("shutdown", $"/s /t {minutes}");
            processStartInfo.CreateNoWindow = true;
            processStartInfo.UseShellExecute = false;
            Process.Start(processStartInfo);
        }
    }
}
