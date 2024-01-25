using System;

namespace labwork.java_lab1
{
    internal class cmd_line
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Meet Mistry...");
            Console.WriteLine("Number of Arguments : " + args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i] + " ");
            }
        }
    }
}
