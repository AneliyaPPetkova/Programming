//Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

using System;
using System.Numerics;

class NFaktorial
{
    static BigInteger Faktorial(int n)
    {
        BigInteger faktorial = 1;
        for (int i = 1; i <= n; i++)
        {
            faktorial = faktorial * i;
        }
        return faktorial;
    }
    static void Main()
    {
        Console.WriteLine("Enter positive integer number n [1..100]:");
        int n;
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out n) && (n > 0) && (n <= 100))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter positive integer number n [1..100]: ");
            }
        }
        Console.WriteLine("n! = {0}",Faktorial(n));
    }
}

