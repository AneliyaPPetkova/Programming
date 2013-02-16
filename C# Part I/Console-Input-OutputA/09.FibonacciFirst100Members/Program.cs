//Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Title = "First 100 Members of the Sequence of Fibonacci";
        BigInteger FirstNumber = 0;
        BigInteger SecondNumber = 1;
        Console.WriteLine("First 100 Members of the Sequence of Fibonacci are:\n");
        Console.Write("{0}, {1}",FirstNumber,SecondNumber);
        for (int i = 0; i <= 48; i++)
        {

            FirstNumber = FirstNumber + SecondNumber;
            SecondNumber = FirstNumber + SecondNumber;
            Console.Write(", {0}, {1}",FirstNumber,SecondNumber);
        }
    }
}

