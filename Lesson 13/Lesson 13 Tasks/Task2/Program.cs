using System;
using System.Management;
using System.Diagnostics;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObjectQuery objectQuery = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(objectQuery);
            ManagementObjectCollection managementObjects = managementObjectSearcher.Get();

            foreach (ManagementObject managementObject in managementObjects)
            {
                Console.WriteLine($"Total visible memory : {(UInt64)managementObject["TotalVisibleMemorySize"] / 1024} MB");
                Console.WriteLine($"Total virtual memory : {(UInt64)managementObject["TotalVirtualMemorySize"] / 1024} MB");
                Console.WriteLine($"Free physical memory : {(UInt64)managementObject["FreePhysicalMemory"] / 1024} MB");
                Console.WriteLine($"Free virtual memory : {(UInt64)managementObject["FreeVirtualMemory"] / 1024} MB");
            }

            Console.WriteLine();

            Process process = Process.GetCurrentProcess();

            long usedMemory = process.PrivateMemorySize64;

            Console.WriteLine("Current used memory is : {0} MB", usedMemory / 1024);
        }
    }
}
