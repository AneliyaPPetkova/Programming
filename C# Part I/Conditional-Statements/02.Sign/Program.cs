//Write a program that shows the sign of the product of three real numbers without calculating it. Use a sequence of if statements.

using System;

class Program
{
    static void Main()
    {
        Console.Title = "The Sign of the Product of three Real Numbers";
        double FirstNumber;
        double SecondNumber;
        double ThirdNumber;
        int p = 0;
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
        if (FirstNumber == 0 || SecondNumber == 0 || ThirdNumber == 0)
        {
            Console.WriteLine("The Product of this three Real Numbers is 0.");
        }
        if (FirstNumber < 0)
        {
            p++;    
        }
        if (SecondNumber < 0)
        {
            p++;  
        }
        if (ThirdNumber < 0)
        {
            p++;
        }

        if ((p % 2 == 0 && p != 0) || (p == 0))
        {
            Console.WriteLine("The sign of the product of this three real numbers is +");
        }
        else if ((p % 2 != 0 && p != 0) )
        {
            Console.WriteLine("The sign of the product of this three real numbers is -");
        }
    }
}

