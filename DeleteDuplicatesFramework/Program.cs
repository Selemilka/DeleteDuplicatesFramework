using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteDuplicatesFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                foreach (var i in Directory.GetFiles(path, "*).mp3"))
                {
                    FileInfo fileInfo = new FileInfo(i);
                    Console.WriteLine(fileInfo.Name);
                    FileSystem.DeleteFile(fileInfo.Name, UIOption.OnlyErrorDialogs, 
                                                         RecycleOption.SendToRecycleBin, 
                                                         UICancelOption.ThrowException);
                    Console.WriteLine("Done!");
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey(true);
        }
    }
}
