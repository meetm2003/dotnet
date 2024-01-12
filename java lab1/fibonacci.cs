using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork.java_lab1
{
    internal class fibonacci
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the Number ");
            int num = Convert.ToInt32(Console.ReadLine());
            int f0 = 0, f1 = 1, f2 = 0;
            Console.Write(f0 + ", " + f1);
            for (int i = 0; i < num; i++)
            {
                f2 = f0 + f1;
                Console.Write(", " + f2);
                f0 = f1;
                f1 = f2;

            }
        }
    }
}
