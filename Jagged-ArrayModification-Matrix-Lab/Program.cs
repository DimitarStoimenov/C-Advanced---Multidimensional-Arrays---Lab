using System;
using System.Linq;

namespace Jagged_ArrayModification_Matrix_Lab
{
    class Program
    {
        static void Main(string[] args)
        { 
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][].ToArray();

            for (int i = 0; i < n; i++)
            {


                matrix[i] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();



            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] rawCommand = command.Split(" ").ToArray();
                if (rawCommand[0] == "Add")
                {
                    int row = int.Parse(rawCommand[1]);
                    int ind = int.Parse(rawCommand[2]);
                    int numToAdd = int.Parse(rawCommand[3]);
                    if (row >= 0 && row < matrix.Length && ind >= 0 && ind < matrix[row].Length)
                    {
                        for (int i = 0; i < matrix[row].Length; i++)
                        {
                            if (i == ind)
                            {
                                matrix[row][i] += numToAdd;
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }

                   
                }
                else if (rawCommand[0] == "Subtract")
                {
                    int row = int.Parse(rawCommand[1]);
                    int ind = int.Parse(rawCommand[2]);
                    int numToAdd = int.Parse(rawCommand[3]);

                    if (row >= 0 && row < matrix.Length && ind >= 0 && ind < matrix[row].Length)
                    {
                        for (int i = 0; i < matrix[row].Length; i++)
                        {
                            if (i == ind)
                            {
                                matrix[row][i] -= numToAdd;
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                

                command = Console.ReadLine();
            }

            foreach (var ar in matrix)
            {
                Console.WriteLine(string.Join(" ", ar));
            }
        }
        
    }
    }

