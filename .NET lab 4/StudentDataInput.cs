using System;
using System.IO;
namespace labwork.NET_lab_4
{
    public class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Spi { get; set; }
    }
    internal class StudentDataInput
    {
        public static void Main()
        {
            student s = new student();
            Console.WriteLine("Enter the Id Number: ");
            s.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name: ");
            s.Name = Console.ReadLine();
            Console.WriteLine("Enter the Spi: ");
            s.Spi = Convert.ToDouble(Console.ReadLine());

            StreamWriter sw = new StreamWriter("D:\\docs\\sem 6\\dotnet\\LabWork\\.NET lab 4\\StudentFile.txt",true);
            sw.WriteLine("Id Number: " + s.Id);
            sw.WriteLine("Name: " + s.Name);
            sw.WriteLine("Spi: " + s.Spi);
            sw.Flush();
            sw.Close();
        }
    }
}
