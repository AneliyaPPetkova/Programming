//Write a program that calculates the greatest common divisor (GCD) of given two numbers.
//Use the Euclidean algorithm (find it in Internet).

using System;

class Program
{
    static void Main()
    {
        Console.Title = "The greatest common divisor (GCD) of given two numbers";
        uint FirstNumber;
        uint SecondNumber;
        uint Smaller;
        uint Bigger;
        uint Remainder;
        uint X;
        Console.WriteLine("Enter Positive Integer Numbers: ");
        while (true)
        {
            Console.Write("First Number = ");
            bool input1 = uint.TryParse(Console.ReadLine(), out FirstNumber);
            Console.Write("Second Number = ");
            bool input2 = uint.TryParse(Console.ReadLine(), out SecondNumber);

            if (input1 && input2 && (FirstNumber > 0) && (SecondNumber > 0))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Positive Integer Numbers: ");
            }
        }
        if (FirstNumber > SecondNumber)
        {
            Bigger = FirstNumber;
            Smaller = SecondNumber;
        }
        else
        {
            Smaller = FirstNumber;
            Bigger = SecondNumber;
        }
        do
        {
            Remainder = Bigger % Smaller;
            X = Smaller;
            Bigger = Smaller;
            Smaller = Remainder;
        } while ((Remainder == 0) == false);
        Console.WriteLine(Bigger);
    }
}

