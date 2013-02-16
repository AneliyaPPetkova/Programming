//* Write a program that reads a positive integer number N (N < 20) 
//from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.

using System;

class Program
{
    static void Main()
    {
        Console.Title = "Numbers arranged as a spiral";
        int N;
        int Number = 1;
        int row = 0;
        int col = 0;
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
        
        int[,] Matrix = new int[N, N];
        do
        {
            for (int i = row, j = col; j <= N - col - 1; j++)
            {
                Matrix[i,j] = Number;
                Number++;
            }
            for (int i = (row + 1), j = (N - col - 1); i <= N - row - 1; i++)
            {
                Matrix[i, j] = Number;
                Number++;
            }
            for (int i = (N - row - 1), j = (N - col - 2); j >= col; j--)
            {
                Matrix[i, j] = Number;
                Number++;
            }
            for (int i = (N - row - 2), j = col; i >= (row + 1); i--)
            {
                Matrix[i, j] = Number;
                Number++;
            }
            row++;
            col++;
        } while (Number <= N*N);
        
        for (int k = 0; k < N; k++)
        {
            for (int m = 0; m < N; m++)
            {
                Console.Write("{0,-4}",Matrix[k,m]);
            }
            Console.WriteLine();
        }
        
    }
}

