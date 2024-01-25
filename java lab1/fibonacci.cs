using System;

namespace labwork.java_lab1
{
    internal class fibonacci
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Meet Mistry...");
            Console.Write("Enter the Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int f0 = 0, f1 = 1, f2 = 0;
            Console.Write(f0 + ", " + f1);
            for (int i = 0; i < num-2; i++)
            {
                f2 = f0 + f1;
                Console.Write(", " + f2);
                f0 = f1;
                f1 = f2;
            }
            Console.WriteLine();
        }
    }
}
