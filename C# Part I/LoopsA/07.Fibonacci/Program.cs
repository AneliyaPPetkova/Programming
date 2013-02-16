//Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci:
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
//Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Title = "First 100 Members of the Sequence of Fibonacci";
        BigInteger FirstNumber = 0;
        BigInteger SecondNumber = 1;
        uint N;
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
        Console.WriteLine("First {0} Members of the Sequence of Fibonacci are:\n",N);
        Console.Write("{0}, {1}", FirstNumber, SecondNumber);
        for (int i = 1; i < N - 1 ; i+=2)
        {
            FirstNumber = FirstNumber + SecondNumber;
            SecondNumber = FirstNumber + SecondNumber;
            Console.Write(", {0}, {1}", FirstNumber, SecondNumber);
        }
        Console.WriteLine();
    }
}

