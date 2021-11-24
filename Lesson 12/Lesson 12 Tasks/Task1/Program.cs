using System;
using System.IO;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ilkin\Documents\MyFolder";

            string[] directories = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);

            foreach (var directory in directories)
            {
                Directory.Delete(directory);
            }

            foreach (var file in files)
            {
                switch (Path.GetExtension(file))
                {
                    case ".jpg":
                        File.Move(file, @"C:\Users\ilkin\Documents\MyFolder\Images", true);
                        break;
                    case ".mp3":
                        File.Move(file, @"C:\Users\ilkin\Documents\MyFolder\Musics", true);
                        break;
                    case ".mp4":
                        File.Move(file, @"C:\Users\ilkin\Documents\MyFolder\Videos", true);
                        break;
                    case ".txt":
                        File.Move(file, @"C:\Users\ilkin\Documents\MyFolder\Documents", true);
                        break;
                    case ".xlsx":
                        File.Move(file, @"C:\Users\ilkin\Documents\MyFolder\Documents", true);
                        break;
                    case ".pptx":
                        File.Move(file, @"C:\Users\ilkin\Documents\MyFolder\Documents", true);
                        break;
                    case ".docx":
                        File.Move(file, @"C:\Users\ilkin\Documents\MyFolder\Documents", true);
                        break;
                    default:
                        File.Move(file, @"C:\Users\ilkin\Documents\MyFolder\Others", true);
                        break;
                }
            }
        }
    }
}
