using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4x4Matrix1
{
    public class DotProduct
    {
        public void dotProduct()
        {
            int i, j;// m, n, p, q;
            int[,] A = new int[7, 7];
            int[,] B = new int[7, 7];
            int[] C = new int[7];
            Console.WriteLine("Matrix 4X4 Dot Product Finder");
            Console.WriteLine("Enter elements of matrix A:");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                    A[i,j] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter elements of matrix B:");
            for (i = 0; i < 4; i++)
                for (j = 0; j < 4; j++)
                    B[i, j] = int.Parse(Console.ReadLine());
            for (i = 0; i < 4; i++)
            {
                C[i] = 0;
                for (j = 0; j < 4; j++)
                    C[i] += A[i, j] * B[i, j];

            }
            // Printing matrix A //
            Console.Write("  Structure of Matrix A:\n");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                    Console.Write(A[i, j] + "\t");
                Console.Write("\n");
            }

            // Printing matrix B //
            Console.Write("  Structure of Matrix B:\n");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                    Console.Write(B[i, j] + "\t");
                Console.Write("\n");
            }
            Console.WriteLine("\nThe Matrices Dot product is:");
            for (i = 0; i < 4; i++)
                Console.Write(C[i] + " ");

        }

    }
}
