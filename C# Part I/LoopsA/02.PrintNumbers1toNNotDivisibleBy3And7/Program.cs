//Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

using System;

class Program
{
    static void Main()
    {
        Console.Title = "The Numbers from 1 to N not divisible by 3 and 7 at the same time";
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
        Console.WriteLine("The Numbers From 1 to {0} not Divisible by 3 and 7 at the same time: ", N);
        for (int i = 1; i <= N; i++)
        {
            if (i % (3*7) == 0)
            {
                continue;
            }
            else
            {
            Console.WriteLine(i);
            }
        }
    }
}

