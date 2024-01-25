using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork.NET_lab_4
{
    internal class FileReadAppend
    {
        public static void Main()
        {
            StreamReader sr1 = new StreamReader("D:\\docs\\sem 6\\dotnet\\labwork\\.NET lab 4\\file1.txt");
            StreamReader sr2 = new StreamReader("D:\\docs\\sem 6\\dotnet\\labwork\\.NET lab 4\\file2.txt");
            StreamReader sr3 = new StreamReader("D:\\docs\\sem 6\\dotnet\\labwork\\.NET lab 4\\file3.txt");

            StreamWriter sw = new StreamWriter("D:\\docs\\sem 6\\dotnet\\labwork\\.NET lab 4\\mainfile.txt",true);
            sw.WriteLine(sr1.ReadLine());
            sw.WriteLine(sr2.ReadLine());
            sw.WriteLine(sr3.ReadLine());
            sw.Flush();
            sr1.Close();
            sr2.Close();
            sr3.Close();
            sw.Close();
        }
    }
}
