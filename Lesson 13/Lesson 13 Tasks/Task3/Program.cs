using System;
using System.Diagnostics;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = GetCurrentCPUUsage();
            Console.WriteLine(result);
        }

        public static string GetCurrentCPUUsage()
        {
            var cpuCounter = new PerformanceCounter
            {
                CategoryName = "Processor",
                CounterName = "% Processor Time",
                InstanceName = "_Total"
            };

            cpuCounter.NextValue();

            return cpuCounter.NextValue() + "%";
        }
    }
}
