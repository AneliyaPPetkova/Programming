//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter First Number:");
        float FirstNumber = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second Number:");
        float SecondNumber = float.Parse(Console.ReadLine());
        float Greater = Math.Max(FirstNumber, SecondNumber);
        Console.WriteLine("The Greater Number is: {0}",Greater);
    }
}

