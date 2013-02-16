//Sort 3 real values in descending order using nested if statements.

using System;

class Program
{
    static void Main()
    {
        Console.Title = "Sort 3 Real Values in Descending Order";
        double FirstNumber;
        double SecondNumber;
        double ThirdNumber;
        double X;
        Console.Write("Enter First Real Number:");
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out FirstNumber))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Real Number: ");
            }
        }
        Console.Write("Enter Second Real Number:");
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out SecondNumber))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Real Number: ");
            }
        }
        Console.Write("Enter Third Real Number:");
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out ThirdNumber))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Real Number: ");
            }
        }
        if (FirstNumber > SecondNumber)
        {
            if (FirstNumber > ThirdNumber)
            {
                Console.WriteLine("{0} is the Biggest Number of this three Integers", FirstNumber);
            }
            else
            {
                Console.WriteLine("{0} is the Biggest Number of this three Integers", ThirdNumber);
                X = FirstNumber;
                FirstNumber = ThirdNumber;
                ThirdNumber = X;
            }
        }
        else
        {
            if (SecondNumber > ThirdNumber)
            {
                Console.WriteLine("{0} is the Biggest Number of this three Integers", SecondNumber);
                X = FirstNumber;
                FirstNumber = SecondNumber;
                SecondNumber = X;
            }
            else
            {
                Console.WriteLine("{0} is the Biggest Number of this three Integers", ThirdNumber);
                X = FirstNumber;
                FirstNumber = ThirdNumber;
                ThirdNumber = X;
            }
        }
        if (SecondNumber < ThirdNumber)
        {
            X = SecondNumber;
            SecondNumber = ThirdNumber;
            ThirdNumber = X;
        }
        Console.WriteLine("{0}, {1}, {2}",FirstNumber,SecondNumber,ThirdNumber);
    }
}

