using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.NxNMatrixes
{
    class NxNMatrixes
    {
        static void Main(string[] args)
        {
            int N;
            int Number = 1;

            Console.Write("Enter Positive Integer Number N < 20: ");
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out N) && (N > 0) && (N < 20))
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid input. Enter Positive Integer Number N < 20: ");
                }
            }

            int[,] Matrix1 = new int[N, N];
            int[,] Matrix2 = new int[N, N];
            int[,] Matrix3 = new int[N, N];
            int[,] Matrix4 = new int[N, N];
            //A) :
            do
            {
                for (int col = 0; col < N; col++)
                {
                    for (int row = 0; row < N; row++)
                    {
                        Matrix1[row, col] = Number;
                        Number++;
                    }                    
                }
            } while (Number <= N * N);
            Console.WriteLine();
            Console.WriteLine("a)");
            Console.WriteLine();
            for (int k = 0; k < N; k++)
            {
                for (int m = 0; m < N; m++)
                {
                    Console.Write("{0,-4}", Matrix1[k, m]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //B) :

            Number = 1;
            do
            {
                for (int col = 0; col < N; col++)
                {
                    if (col == 0 || col % 2 == 0)
                    {
                        for (int row = 0; row < N; row++)
                        {
                            Matrix2[row, col] = Number;
                            Number++;
                        }                        
                    }
                    else
                    {
                        for (int row = N - 1; row >= 0; row--)
                        {
                            Matrix2[row, col] = Number;
                            Number++;
                        }     
                    }
                }
            } while (Number <= N * N);
            Console.WriteLine();
            Console.WriteLine("b)");
            Console.WriteLine();
            for (int k = 0; k < N; k++)
            {
                for (int m = 0; m < N; m++)
                {
                    Console.Write("{0,-4}", Matrix2[k, m]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //D) :

            Number = 1;
            int row4 = 0;
            int col4 = 0;
            do
            {
                for (int i = row4, j = col4; i <= N - row4 - 1; i++)
                {
                    Matrix4[i, j] = Number;
                    Number++;
                }
                for (int i = (N - row4 - 1), j = (col4 + 1); j <= N - col4 - 1; j++)
                {
                    Matrix4[i, j] = Number;
                    Number++;
                }
                for (int i = (N - row4 - 2), j = (N - col4 - 1); i >= row4; i--)
                {
                    Matrix4[i, j] = Number;
                    Number++;
                }
                for (int i = row4, j = (N - col4 - 2); j >= (col4 + 1); j--)
                {
                    Matrix4[i, j] = Number;
                    Number++;
                }
                row4++;
                col4++;
            } while (Number <= N * N);
            Console.WriteLine();
            Console.WriteLine("d)");
            Console.WriteLine();
            for (int k = 0; k < N; k++)
            {
                for (int m = 0; m < N; m++)
                {
                    Console.Write("{0,-4}", Matrix4[k, m]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
         
        }
    }
}
