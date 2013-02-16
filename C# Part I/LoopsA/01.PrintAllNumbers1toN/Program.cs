//Write a program that prints all the numbers from 1 to N.

using System;

class Program
{
    static void Main()
    {
        Console.Title = "Numbers from 1 to N";
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
        Console.WriteLine("The Numbers From 1 to {0}: ",N);
        for (int i = 1; i <= N; i++)
        {
            
            Console.WriteLine(i);
        }
    }
}

