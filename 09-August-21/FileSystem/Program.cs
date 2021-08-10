using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Filesystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            string source = @"C:\Training\09-August-21\FileSystem\MainFolder\Folder1\Folder2";
            string target = @"C:\Training\09-August-21\Operation\Target\TransferData";

            if (!(Directory.Exists(source)))
            {
                Directory.CreateDirectory(source);
            }
            if (!(Directory.Exists(target)))
            {
                Directory.CreateDirectory(target);
            }
            string[] files = Directory.GetFiles(source);
            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);
                
                var text = File.ReadAllText(file);

                if (Regex.IsMatch(file, @"\.txt$") && text.Contains("Gislen Software"))
                {
                    var path = Path.Combine(target, info.Name);
                    File.Move(file, path);
                }

                if (Regex.IsMatch(file, @"\.jpg$|\.png$|\.gif$") && info.Length <= 2e+6)
                {
                    var path = Path.Combine(target, info.Name);
                    File.Move(file, path);
                }

            }
        }
    }
}