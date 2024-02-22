using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace labwork.java_lab5
{
    internal class FileDirectory
    {
        public static void Main()
        {
            DriveInfo[] d = DriveInfo.GetDrives();
            foreach(DriveInfo d2 in d) { 
                Console.WriteLine(d2.Name);
                
            }
            DirectoryInfo dir = new DirectoryInfo("d:\\");
            foreach(DirectoryInfo di in dir.GetDirectories())
            {
                Console.WriteLine(di.Name);
            }
            FileInfo fi = new FileInfo("D:\\docs\\sem 6\\dotnet\\LabWork\\.NET lab 4\\demo.cs");
            Console.WriteLine(fi.Name);   
        }
    }
}
