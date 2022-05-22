using System;
using System.Linq;

namespace SquarewithMaximumSum_Matrix_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = num[0];
            int cols = num[1];
            int[,] matrix = new int[rows, cols];
            long maxSum = long.MinValue;
            int currSum = 0;
            string maxR = "";
            

            for (int r = 0; r < rows; r++)
            {
                int[] numCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int c = 0; c < numCols.Length; c++)
                {
                    matrix[r, c] = numCols[c];
                }
            }

            for (int r = 0; r < matrix.GetLength(0) - 1; r++)
            {
                for (int c = 0; c < matrix.GetLength(1) - 1; c++)
                {   currSum = matrix[r, c] + matrix[r, c + 1] + matrix[r + 1, c] + matrix[r + 1, c + 1];
                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        maxR = matrix[r, c] + " " + matrix[r, c + 1] + "\r\n" +
                               matrix[r + 1, c] + " " + matrix[r + 1, c + 1];


                    }
                       
                    
                    
                }
            }

            Console.WriteLine(maxR);
            Console.WriteLine(maxSum);

        }
    }
}
