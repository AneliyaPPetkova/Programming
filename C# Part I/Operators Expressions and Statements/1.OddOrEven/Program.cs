//Write an expression that checks if given integer is odd or even.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Integer:");
        int Number = int.Parse(Console.ReadLine());
        if (Number % 2 == 0)
        {
            Console.WriteLine("The Number is Even"); 
        }
        else
        {
            Console.WriteLine("The Number is Odd");
        }
    }
}

