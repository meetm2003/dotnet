using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork.java_lab5
{
    internal class Number_trycatch
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many numbers you want to add : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.WriteLine("Enter " + n + " numbers : ");
            for (int i = 0; i < n; i++)
            {
                int no = Convert.ToInt32(Console.ReadLine());
                try
                {
                    if (no < 0) throw new Exception();
                    sum += no;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Negative number not allowed :" + e);
                }
            }
            Console.WriteLine("Sum of positive numbers : " + sum);
        }
    }
}
