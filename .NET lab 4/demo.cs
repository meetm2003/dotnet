using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork.NET_lab_4
{
    internal class demo
    {
        public static void Main()
        {
            StreamReader sr = new StreamReader("D:\\docs\\sem 6\\dotnet\\LabWork\\.NET lab 4\\demo.txt");
            int i = sr.GetHashCode();
            StreamWriter sw = new StreamWriter("D:\\docs\\sem 6\\dotnet\\LabWork\\.NET lab 4\\demo.txt");

        }
    }
}
