using System;
using _4x4Matrix;
using _4x4Matrix1;
using _4x4Matrix2;

namespace MatrixProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            DotProduct doris = new DotProduct();
            Multiplication matrix = new Multiplication();
            Determinant Nife = new Determinant();

            Console.WriteLine("Select 1 to check the Determinant of a Matrix");
            Console.WriteLine("Select 2 to check the Dot Product of a Matrix");
            Console.WriteLine("Select 3 to check the Multiplication of a Matrix");
            string matrixType = Console.ReadLine();
            if (matrixType == "1")
            {
                Nife.Entry();
            }
            else if (matrixType == "2")
            {
                doris.dotProduct();
            }
            else
            {
                matrix.multiplication();
            };

        }
    }
}
