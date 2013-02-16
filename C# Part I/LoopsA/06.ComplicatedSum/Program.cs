//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Title = "The SumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N";
        uint N;
        uint X;
        decimal Power = 1;
        decimal FaktorialN = 1;
        decimal S = 1;
        Console.WriteLine("Enter Positive Integer Numbers N and X: ");
        while (true)
        {
            Console.Write("N = ");
            bool input1 = uint.TryParse(Console.ReadLine(), out N);
            Console.Write("X = ");
            bool input2 = uint.TryParse(Console.ReadLine(), out X);

            if (input1 && input2 && (X > 0) && N > 0)
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Positive Integer Numbers N and X: ");
            }
        }
        for (uint i = 1; i <= N; i++)
        {
            FaktorialN *= i;
            Power *= X;
            S += FaktorialN / Power;
        }
        decimal Round = Math.Round(S , 4);
        Console.WriteLine("The Sum S = 1 + 1!/X + 2!/X^2 + … + N!/X^N = {0}", Round);
    }
}

