using System;

namespace RotateMatrix
{
    class Program
    {
        byte[,] RotateMatrix(byte[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            {
                return matrix;
            }

            byte[,] rotateMatrix = new byte[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    rotateMatrix[i, j] = matrix[matrix.GetLength(0) - j - 1, i];
                }
            }

            return rotateMatrix;
        }

        void PrintMatrix(byte[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            byte[,] matrix = new byte[,] {
                {0,1,2},
                {3,4,5},
                {6,7,8}
            };

            Console.WriteLine("Current matrix:");
            p.PrintMatrix(matrix);


            Console.WriteLine("Rotated matrix:");
            p.PrintMatrix(p.RotateMatrix(matrix));
        }
    }
}
