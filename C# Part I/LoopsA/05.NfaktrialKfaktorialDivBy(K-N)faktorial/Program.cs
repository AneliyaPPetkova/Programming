///Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Title = "N!*K! / (K-N)! for given N and K (1<N<K)";
        uint N;
        uint K;
        BigInteger FaktorialK = 1;
        BigInteger FaktorialN = 1;
        BigInteger FaktorialPartK = 1;
        BigInteger FullExpression;
        Console.WriteLine("Enter Positive Integer Numbers N and K (K > N): ");
        while (true)
        {
            Console.Write("N = ");
            bool input1 = uint.TryParse(Console.ReadLine(), out N);
            Console.Write("K = ");
            bool input2 = uint.TryParse(Console.ReadLine(), out K);
            
            if (input1 && input2 && (K > N) && N > 0)
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Positive Integer Numbers N and K (K > N): ");
            }
        }

        for (uint i = 1; i <= K; i++)
        {
            FaktorialK *= i;
        }
        for (uint j = 1; j <= N; j++)
        {
            FaktorialN *= j;
        }
        for (uint k = 1; k <= K - N; k++)
        {
            FaktorialPartK *= k;
        }
        FullExpression = (FaktorialK * FaktorialN) / FaktorialPartK; 
        Console.WriteLine("N!*K! / (K-N)! = {0}", FullExpression);
    }
}

