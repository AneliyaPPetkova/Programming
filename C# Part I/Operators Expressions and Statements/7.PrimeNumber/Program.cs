//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Integer:");
        int Number = int.Parse(Console.ReadLine());
        bool CheckInteger =(((Number == 1) || (Number == 2) || (Number == 3) || (Number == 7)) || ((Number % 2 != 0) && (Number % 3 != 0) && (Number % 5 != 0) && (Number % 7 != 0)));
        if (CheckInteger)
        {
            Console.WriteLine("The Number {0} is prime.",Number);
        }
        else
        {
            Console.WriteLine("The Number {0} is not prime.",Number);
        }
    }
}

