using System;

namespace labwork.java_lab4
{
    internal class matrix_transpose
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Meet Mistry...");
            Console.WriteLine("Enter number of row: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of colums : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[m,n];
            Console.WriteLine("Enter array elements : ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Transposed Matrix \n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[j,i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
