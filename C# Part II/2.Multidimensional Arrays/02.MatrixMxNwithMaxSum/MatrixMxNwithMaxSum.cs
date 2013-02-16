//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MatrixMxNwithMaxSum
{
    class MatrixMxNwithMaxSum
    {
        static void Main(string[] args)
        {
            int n;
            int m;
            int sum = 0;
            int maxSum = 0;
            int index = 0;
            Console.Write("Enter Positive Integer Numbers N >= 3 & M >= 3: ");
            while (true)
            {
                string input1 = Console.ReadLine();
                string input2 = Console.ReadLine();
                if (int.TryParse(input1, out n) && int.TryParse(input2, out m) && (n >= 3) && (m >= 3))
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid input. Enter Positive Integer Numbers N >= 3 & M >= 3: ");
                }
            }
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("matrix[{0},{1}] = ",i ,j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //Printing NxM matrix:
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
            // Calculating the maximal sum:
            for (int i = 0; i <= n - 3; i++)
            {
                for (int j = 0; j <= m - 3; j++)
                {
                    for (int row = 0; row < 3; row++)
                    {
                        for (int col = 0; col < 3; col++)
                        {
                            sum = sum + matrix[row + i, col + j];
                            if (sum > maxSum)
                            {
                                maxSum = sum;
                                index = i;
                            }
                        }
                    }
                    sum = 0;
                    
                }
            }
            //Print matrix 3x3:
            Console.WriteLine("Matrix 3x3 with Maximal Sum:");
            for (int i = index; i < index + 3; i++)
            {
                for (int j = index; j < index + 3; j++)
                {
                    Console.Write(matrix[i , j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Maximal Sum is: {0}", maxSum);
        }
    }
}
