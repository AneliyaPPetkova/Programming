//Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
{
    static int index;
    static bool isNegative;
    static void Binary(int number)
    {
        int remainder;
        int[] strRemainder = new int[32];
        for (int i = 0; i < strRemainder.Length; i++)
		{
            remainder = number % 2;
            number = number / 2;
            strRemainder[i] = remainder;
            if (number / 2 == 1)
            {
                remainder = number % 2;
                number = number / 2;
                strRemainder[i + 1] = remainder;
                strRemainder[i + 2] = number;
                index = i + 2;
                break;
            }			 
		}

        ReverseArray(strRemainder);
    }
    static void ReverseArray(int[] array)
    {
        Array.Reverse(array);
        PrintArray(array);
    }

    static void PrintArray(int[] arr)
    {
        if (isNegative == true)
        {
            arr[index + 1] = 1;
        }
        for (int i = 32 - (index + 1); i < 32 ; i++)
        {
            Console.Write(arr[i]);
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter some Decimal number:");
        int number;
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out number))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter some Decimal number: ");
            }
        }
        if (number < 0)
        {
            number = Int32.MaxValue + number + 1;
            isNegative = true;
        }
        
        Binary(number);
    }
}

