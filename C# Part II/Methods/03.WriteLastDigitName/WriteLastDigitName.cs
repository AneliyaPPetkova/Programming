//Write a method that returns the last digit of given integer as an English word. 
//Examples: 512  "two", 1024  "four", 12309  "nine".

using System;

class WriteLastDigitName
{
    static int GetDigit(int number)
    {
        return number = number % 10;
    }
    static void PrintEnglishWord(int digit)
    {
        switch (digit)
        {
            case 0:
                Console.WriteLine("Null");
                break;
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8:
                Console.WriteLine("Eight");
                break;
            case 9:
                Console.WriteLine("Nine");
                break;
            default:
                break;
        }
    }
    static void Main()
    {
        int number;
        Console.WriteLine("Enter some integer number:");
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out number))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter integer number: ");
            }
        }
        int digit = GetDigit(number);
        Console.Write("{0} -> ", number);
        PrintEnglishWord(digit);
    }
}

