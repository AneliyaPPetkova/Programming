﻿//* Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
//N = 10  N! = 3628800  2
//N = 20  N! = 2432902008176640000  4
//Does your program work for N = 50 000?
//Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Title = "Trailing Zeros";
        uint N;
        long TrailingZeros = 0;
        BigInteger Faktorial = 1;
        long P = 1;
        
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
            Faktorial *= i;
        }
        Console.WriteLine("N! = {0}", Faktorial);
        for (int i = 0; i < N; i++)
        {
            P *= 5;
            TrailingZeros += (N / P);
        }
        Console.WriteLine("At the End Of The Number N! present {0} Trailing Zeros.",TrailingZeros);
    }
}

