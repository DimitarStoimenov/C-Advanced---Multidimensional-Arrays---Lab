using System;
using System.Linq;


namespace PascalTriangle_Matrix_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[][] output = new int[num][].ToArray();

            for (int r = 0; r < num; r++)
            {

                output[r] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();



            }
        }
    }
}
