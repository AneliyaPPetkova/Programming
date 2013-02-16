//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Please Enter Some Positive Integer Number: n = ");
        int n;
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out n) && (n > 0))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Positive Integer Number: n = ");
            }
        }
        Console.WriteLine("The Numbers in the Interval [1..{0}] are:",n);
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

