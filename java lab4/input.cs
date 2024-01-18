using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork.java_lab4
{
    internal class input
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter statement : ");
            String str = Console.ReadLine();
            Console.WriteLine("Enter word : ");
            String ch = Console.ReadLine();
            Console.WriteLine("Boolean : ");
            bool bl =  Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Enter integer number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter float number : ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter double number : ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter long number : ");
            long num3 = Convert.ToInt64(Console.ReadLine());


            Console.WriteLine("String : " + str);
            Console.WriteLine("Word : " + ch);
            Console.WriteLine("Boolean : " + bl);
            Console.WriteLine("Integer : " + num);
            Console.WriteLine("Float : " + num1);
            Console.WriteLine("Double : " + num2);
            Console.WriteLine("Long : " + num3);


        }
    }
}
