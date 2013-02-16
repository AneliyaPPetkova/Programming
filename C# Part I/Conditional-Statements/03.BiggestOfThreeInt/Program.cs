//Write a program that finds the biggest of three integers using nested if statements.

using System;

class Program
{
    static void Main()
    {
        Console.Title = "The Biggest of Three Integers";
        int FirstNumber;
        int SecondNumber;
        int ThirdNumber;
        
        Console.Write("Enter First Integer Number:");
        while (true)
        {
            string input1 = Console.ReadLine();
            if (int.TryParse(input1, out FirstNumber))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Integer Number: ");
            }
        }
        Console.Write("Enter Second Integer Number:");
        while (true)
        {
            string input2 = Console.ReadLine();
            if (int.TryParse(input2, out SecondNumber))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Integer Number: ");
            }
        }
        Console.Write("Enter Third Integer Number:");
        while (true)
        {
            string input3 = Console.ReadLine();
            if (int.TryParse(input3, out ThirdNumber))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Integer Number: ");
            }
        }
        if (FirstNumber > SecondNumber)
        {
            if (FirstNumber > ThirdNumber)
            {
                Console.WriteLine("{0} is the Biggest Number of this three Integers",FirstNumber);
            }
            else
            {
                Console.WriteLine("{0} is the Biggest Number of this three Integers",ThirdNumber);
            }
        }
        else
        {
            if (SecondNumber > ThirdNumber)
            {
                Console.WriteLine("{0} is the Biggest Number of this three Integers",SecondNumber);
            }
            else
            {
                Console.WriteLine("{0} is the Biggest Number of this three Integers",ThirdNumber);
            }
        }
    }
}

