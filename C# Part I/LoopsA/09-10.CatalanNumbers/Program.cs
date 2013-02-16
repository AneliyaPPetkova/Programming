//Write a program to calculate the Nth Catalan number by given N.

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Title = "The Nth Catalan number";
        uint N;
        BigInteger P;
        BigInteger FaktorialN = 1;
        BigInteger Faktorial2N = 1;
        BigInteger FaktorialNPlus1 = 1;
        Console.Write("Enter Positive Integer Number N: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (uint.TryParse(input, out N) && (N > 0))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Positive Integer Number N: ");
            }
        }
        for (int i = 1; i <= N; i++)
        {
            FaktorialN *= i;
        }
        for (int j = 1; j <= 2*N; j++)
        {
            Faktorial2N *= j;
        }
        for (int k = 1; k <= N + 1; k++)
        {
            FaktorialNPlus1 *= k;
        }
        P = (Faktorial2N / (FaktorialNPlus1 * FaktorialN));    
        
        Console.WriteLine("The {1}th Catalan number is {0}",P ,N);
    }
}

