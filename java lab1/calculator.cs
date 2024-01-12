using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork.java_lab1
{
    internal class calculator
    {
        public static void Main(string[] args)
        {
            int x = 10, y = 5;
            Console.WriteLine("Addition : " + (x + y));
            Console.WriteLine("Subtraction : " + (x - y));
            Console.WriteLine("Multiplication : " + (x * y));
            Console.WriteLine("division : " + (x / y));
            Console.WriteLine("Modulo : " + (x % y));
        }
    }
}
