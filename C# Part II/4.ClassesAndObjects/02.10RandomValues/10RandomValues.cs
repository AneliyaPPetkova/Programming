//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RandomValues
{
    static void Main()
    {
        Console.WriteLine("10 Random Values in the range [100,200]:");
        Random values = new Random();
        for (int number = 1; number <= 10; number++)
        {
            int randomValue = values.Next(100,200);
            Console.Write("{0} ", randomValue);
        }
        Console.WriteLine();

    }
}

