using System;

namespace labwork.java_lab4
{
    internal class matrix_addition
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Meet Mistry...");
            Console.WriteLine("Enter number of row: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of colums : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m,n];
            int[,] b = new int[m,n];
            int[,] c = new int[m,n];
            Console.WriteLine("Enter elements of a[][] : ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter elements of b[][] : ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Addition of a[][] + b[][] \n");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    c[i,j] = a[i,j] + b[i,j];
                    Console.Write(c[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
