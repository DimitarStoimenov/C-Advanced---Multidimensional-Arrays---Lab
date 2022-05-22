using System;
using System.Linq;

namespace SymbolInMatrix_Matrix_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            char[,] matrix = new char[num, num];

            for (int r = 0; r < num; r++)
            {
                char[] charArr = Console.ReadLine().ToCharArray();

                for (int c = 0; c < charArr.Length; c++)
                {
                    matrix[r, c] = charArr[c];
                }
            }
           
            char[] charSymb = Console.ReadLine().ToCharArray();

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                 for (int c = 0; c < matrix.GetLength(1); c++)
                {
                   
                    if (matrix[r, c] == charSymb[0])
                    {
                        Console.WriteLine($"({r}, {c})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{charSymb[0]} does not occur in the matrix");
        }
    }
}
