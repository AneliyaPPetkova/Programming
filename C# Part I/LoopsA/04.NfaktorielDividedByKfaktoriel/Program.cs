//Write a program that calculates N!/K! for given N and K (1<K<N).

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Title = "N!/K! for given N and K (1<K<N)";
        uint N;
        uint K;
        BigInteger Faktorial = 1; 
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
        Console.Write("Enter Positive Integer Number K < N: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (uint.TryParse(input, out K) && (K > 0) && (K < N))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Positive Integer Number K < N: ");
            }
        }
        for (uint i = K + 1; i <= N; i++)
        {
            Faktorial *= i;   
        }
        Console.WriteLine("N!/K! = {0}", Faktorial);
    }
}

