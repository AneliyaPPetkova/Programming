//Write a program that reads from the console a positive integer number N (N < 20) and outputs a simetrical matrix.

using System;

class Program
{
    static void Main()
    {
        Console.Title = "Simetrical Matrix";
        byte N;
        Console.Write("Enter Positive Integer Number N < 20: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (byte.TryParse(input, out N) && (N > 0) && (N < 20))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Positive Integer Number N < 20: ");
            }
        }
        for (int i = 1; i <= N; i++)
        {
            for (int j = i; j <= i + N - 1; j++)
            {
                Console.Write("{0 , -4}", j);
            }
            Console.WriteLine();
        }
    }
}

