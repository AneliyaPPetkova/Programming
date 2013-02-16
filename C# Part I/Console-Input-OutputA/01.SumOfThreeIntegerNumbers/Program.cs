//Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class Program
{
    static void Main()
    {
        Console.Title = "Sum of 3 Int Numbers";
        Console.WriteLine("Enter 3 Integer Numbers:");
        int FirstNumber = int.Parse(Console.ReadLine());
        int SecondNumber = int.Parse(Console.ReadLine());
        int ThirdNumber = int.Parse(Console.ReadLine());
        int Sum = FirstNumber + SecondNumber + ThirdNumber;
        Console.WriteLine("Sum of {0},{1},{2} is {3}.",FirstNumber,SecondNumber,ThirdNumber,Sum);
    }
}

