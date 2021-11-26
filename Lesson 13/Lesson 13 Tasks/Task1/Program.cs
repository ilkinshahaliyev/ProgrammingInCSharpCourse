using System;
using System.IO;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Computer Drive Information is here :\n");

            int countOfDisk = 0;

            foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
            {
                if (driveInfo.DriveType == DriveType.Fixed)
                {

                    countOfDisk++;

                    Console.WriteLine($"Drive name : {driveInfo.Name}" + "\n"
                        + $"Drive label : {driveInfo.VolumeLabel}" + "\n"
                        + $"Total size : {driveInfo.TotalSize / 1048576} MB" + "\n"
                        + $"Used size : {(driveInfo.TotalSize - driveInfo.TotalFreeSpace) / 1048576} MB" + "\n"
                        + $"Total available free space : {driveInfo.AvailableFreeSpace / 1048576} MB" + "\n"
                        + $"Total free space : {driveInfo.TotalFreeSpace / 1048576} MB" + "\n"
                        + $"Drive Type : {driveInfo.DriveType}");

                    Console.WriteLine();
                }
            }

            Console.WriteLine("The count of disk is {0}.", countOfDisk);
        }
    }
}
