//Write a method that reverses the digits of given decimal number. Example: 256  652

using System;

class ReverseDigits
{
    static void Reverse(int number, int length)
    {
        int remainder;
        if (number < 0)
        {
            length = length - 1;
            Console.Write("-");
        }
        for (int i = 0; i < length; i++)
        {
            remainder = Math.Abs(number) % 10;
            number = Math.Abs(number) / 10;
            Console.Write(remainder);            
        }

    }
    static void Main()
    {
        int number;
        int length;
        Console.WriteLine("Enter some number :");

        //Check size:
        while (true)
        {
            string input = Console.ReadLine();
            length = input.Length;
            if (int.TryParse(input, out number))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter integer number: ");
            }
        }
        Console.WriteLine("Reversed number:");
        Reverse(number, length);
        Console.WriteLine();
    }
}

