using System;
using System.IO;

namespace labwork.NET_lab_4
{
    internal class FileIOP
    {
        public static void Main()
        {
            try
            {
                StreamReader sr = new StreamReader("D:\\docs\\sem 6\\dotnet\\labwork\\.NET lab 4\\test.txt");
                Console.WriteLine(sr.ReadLine());
                sr.Close();

                //this is for appending the string in file...
                StreamWriter sw = new StreamWriter("D:\\docs\\sem 6\\dotnet\\labwork\\.NET lab 4\\test.txt",true);
                sw.WriteLine("Hello, I am from FileOP.cs File...");
                sw.Flush();
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
