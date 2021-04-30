using System;
using System.Collections;
using System.Collections.Generic;

namespace ZeroMatrix
{
    class Program
    {
        int[,] ZeroMatrix(int[,] matrix)
        {
            if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            {
                return matrix;
            }

            List<Vector2D> zeroList = new List<Vector2D>();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        Vector2D v = new Vector2D(i, j);
                        zeroList.Add(v);
                    }
                }
            }

            for (int L = 0; L < zeroList.Count; L++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (zeroList[L].X == i || zeroList[L].Y == j)
                        {
                            matrix[i, j] = 0;
                        }
                    }
                }
            }

            return matrix;
        }

        void PrintMatrix(int[,] matrix)
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

            int[,] matrix = new int[,] {
                {0,1,2},
                {3,4,5},
                {6,7,8}
            };

            Console.WriteLine("Current matrix:");
            p.PrintMatrix(matrix);

            Console.WriteLine("Zero matrix:");
            int[,] zeroMatrix;
            zeroMatrix = p.ZeroMatrix(matrix);

            p.PrintMatrix(zeroMatrix);

            matrix = new int[,] {
                {0,1,3,2},
                {3,7,0,5},
                {6,7,6,8}
            };

            Console.WriteLine("Current matrix:");
            p.PrintMatrix(matrix);

            Console.WriteLine("Zero matrix:");
            zeroMatrix = p.ZeroMatrix(matrix);

            p.PrintMatrix(zeroMatrix);

            matrix = new int[,] {
                {0,1,3,2},
                {3,7,9,5},
            };

            Console.WriteLine("Current matrix:");
            p.PrintMatrix(matrix);

            Console.WriteLine("Zero matrix:");
            zeroMatrix = p.ZeroMatrix(matrix);

            p.PrintMatrix(zeroMatrix);
        }

        public struct Vector2D
        {
            public Vector2D(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X
            {
                get;
            }

            public int Y
            {
                get;
            }
        }
    }
}
