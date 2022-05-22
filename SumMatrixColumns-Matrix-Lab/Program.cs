using System;
using System.Linq;
using System.Collections.Generic;

namespace SumMatrixElements_Matrix_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            (int rowsCount, int colCount) = (input[0], input[1]);

            int[,] matrix = new int[rowsCount, colCount];


            for (int r = 0; r < rowsCount; r++)
            {
                int[] collNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int c = 0; c < colCount; c++)
                {
                    matrix[r, c] = collNumbers[c];

                }
            }
            long[] colsSum = new long[colCount];

            for (int col = 0; col < colCount; col++)
            {
                for (int row = 0; row < rowsCount; row++)
                {
                    colsSum[col] += matrix[row, col];
                }
            }
            for (int i = 0; i < colsSum.Length; i++)
            {
                Console.WriteLine(colsSum[i]);
            }





        }
    }
}
