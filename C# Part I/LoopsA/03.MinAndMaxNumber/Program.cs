//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;

class Program
{
    static void Main()
    {
        Console.Title = "Minimal and Maximal Number of a Sequence of N Integer Numbers";
        uint N;
        int Variable;
        int NewNumber = 0;
        int Max = 0;
        int Min = 0;
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
        for (int i = 1; i <= N; i++)
        {
            
            Console.Write("Enter {0} Integer Number: ",i);
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out Variable))
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid input. Enter Integer Number: ");
                }
            }
            NewNumber = Variable;
            if (Max < NewNumber)
            {
                Max = NewNumber;
                
            }
            else if (Min > NewNumber)
            {
                Min = NewNumber;
            } 
        }
        Console.WriteLine("Max Number: {0}",Max);
        Console.WriteLine("Min Number: {0}",Min);

    }
}

