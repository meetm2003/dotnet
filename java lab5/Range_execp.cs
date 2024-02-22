using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork.java_lab5
{
    internal class Range_execp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (n != 0)
            {
                try
                {
                    if (n < -1000 || n > 1000) throw new Exception();
                    sum += n;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Out of range(-1000 to 1000) :" + e);
                }
                Console.WriteLine("Enter next number (Press 0 to Exit) : ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Sum of positive numbers : " + sum);
        }
    }
}
