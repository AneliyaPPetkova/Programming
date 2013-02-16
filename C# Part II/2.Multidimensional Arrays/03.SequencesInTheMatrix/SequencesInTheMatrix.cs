//We are given a matrix of strings of size N x M. 
//Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. 
//Write a program that finds the longest sequence of equal strings in the matrix. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SequencesInTheMatrix
{
    class SequencesInTheMatrix
    {
        static void Main(string[] args)
        {
            int n;
            int m;
            int count = 1;
            int tempcount = 1;
            int indexRow = 0;
            int indexCol = 0;
            Console.Write("Enter Positive Integer Numbers N > 0 & M > 0 : ");
            while (true)
            {
                string input1 = Console.ReadLine();
                string input2 = Console.ReadLine();
                if (int.TryParse(input1, out n) && int.TryParse(input2, out m) && (n >= 0) && (m >= 0))
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid input. Enter Positive Integer Numbers N > 0 & M > 0: ");
                }
            }
            string[,] matrix = new string[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("matrix[{0},{1}] = ", i, j);
                    matrix[i, j] = Console.ReadLine();
                }
            }
            Console.WriteLine();
            //Printing NxM matrix:
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //Rows search:
            for (int row = 0; row < n; row++)
            {
                for (int col = 1; col < m; col++)
                {
                    if (matrix[row , col] == matrix[row , col - 1])
                    {
                        ++tempcount;
                        if (tempcount > count)
                        {
                            count = tempcount;
                            indexRow = row;
                            indexCol = col;
                        }
                    }
                    else
                    {
                        tempcount = 1;
                    }                    
                }
            }
            tempcount = 1;
            //Cols search:
            for (int col = 0; col < m; col++)
            {
                for (int row = 1; row < n; row++)
                {
                    if (matrix[row, col] == matrix[row - 1, col])
                    {
                        ++tempcount;
                        if (tempcount > count)
                        {
                            count = tempcount;
                            indexRow = row;
                            indexCol = col;
                        }
                    }
                    else
                    {
                        tempcount = 1;
                    }
                }
            }
            tempcount = 1;
            //Diagonal search:
            if (m <= n)
            {
                for (int col = 1; col < m; col++)
                {
                    if (matrix[col, col] == matrix[col - 1, col - 1])
                    {
                        ++tempcount;
                        if (tempcount > count)
                        {
                            count = tempcount;
                            indexCol = col;
                            indexRow = indexCol;
                        }
                    }
                    else
                    {
                        tempcount = 1;
                    }
                }
            }
            else
            {
                for (int col = 1; col < n; col++)
                {
                    if (matrix[col, col] == matrix[col - 1, col - 1])
                    {
                        ++tempcount;
                        if (tempcount > count)
                        {
                            count = tempcount;
                            indexCol = col;
                            indexRow = indexCol;
                        }
                    }
                    else
                    {
                        tempcount = 1;
                    }
                }
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(matrix[indexRow,indexCol] + " ");
            }
            Console.WriteLine();
        }
    }
}
