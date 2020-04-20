using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba2._4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int m, n, i, j,ch;
            Console.Write("Enter the Order of the Matrix n: ");
            n = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the Order of the Matrix m: ");
            m = Convert.ToInt16(Console.ReadLine());
            int[,] A = new int[10, 10];
            Console.Write("\nEnter The Matrix Elements : ");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    A[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("\nMatrix A : ");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write(A[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.Write("Enter The Matrix Elements k: ");
            int k = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter The Matrix Elements p: ");
            int p = Convert.ToInt16(Console.ReadLine());
            for (j = 0; j < m; j++)
            {
                for (i = 0; i < n; i++)
                {
                    ch = A[i, k - 1];
                    A[i, k - 1] = A[i, p - 1];
                    A[i, p - 1] = ch;
                }
            }

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write(A[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
