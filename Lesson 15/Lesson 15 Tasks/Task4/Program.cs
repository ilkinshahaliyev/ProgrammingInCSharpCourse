using System;
using System.Collections.Generic;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProcessToKill(new List<string>
            {
                "Launcher.exe",
                "Explorer.exe",
                "Config.exe"
            });
        }

        public static List<string> ProcessToKill(List<string> process)
        {
            List<string> processToKill = new List<string>(3);

            Console.WriteLine(string.Format("Capacity {0}", processToKill.Capacity));

            Console.WriteLine(string.Format("Count {0}", processToKill.Count));

            foreach (var item in process)
            {
                if (item != "Explorer.exe")
                {
                    processToKill.Add(item);
                }
            }

            foreach (var p in processToKill)
            {
                Console.WriteLine(p);
            }

            return processToKill;
        }
    }
}
