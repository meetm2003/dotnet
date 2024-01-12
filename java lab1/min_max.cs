using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork.java_lab1
{
    internal class min_max
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter value of a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of c : ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
                Console.WriteLine(a + " is Maximum");


        else if (b > a && b > c)
                Console.WriteLine(b + " is Maximum");


        else
                Console.WriteLine(c + " is Maximum");

            if (a < b && a < c)
                Console.WriteLine(a + " is Minimum");


        else if (b < a && b < c)
                Console.WriteLine(b + " is Minimum");


        else
                Console.WriteLine(c + " is Minimum");

        }
    }
}
