using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork.java_lab1
{
    internal class cmd_line
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Number of Arguments : " + args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i] + " ");
            }
        }
    }
}
