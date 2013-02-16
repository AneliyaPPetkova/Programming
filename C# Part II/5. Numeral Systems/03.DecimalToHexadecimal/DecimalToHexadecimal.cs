//Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecimalToHexadecimal
{
    static int index;
    static void DecToHex(int number)
    {
        int remainder;
        int[] strRemainder = new int[32];
        for (int i = 0; i < strRemainder.Length; i++)
        {
            remainder = number % 16;
            number = number / 16;
            strRemainder[i] = remainder;
            if (number / 16 == 1)
            {
                remainder = number % 16;
                number = number / 16;
                strRemainder[i + 1] = remainder;
                strRemainder[i + 2] = number;
                index = i + 2;
                break;
            }
            else if (number / 16 == 0)
            {
                remainder = number % 16;
                strRemainder[i + 1] = remainder;
                index = i + 1;
                break;
            }
        }

        ReverseArray(strRemainder);
        Hexadecimal(strRemainder);
    }
    static void ReverseArray(int[] array)
    {
        Array.Reverse(array);
    }
    static void Hexadecimal(int[] array)
    {
        string[] strRemainder = new string[32];
        for (int i = 0; i < strRemainder.Length; i++)
        {
            switch (array[i])
            {
                case 0:
                    strRemainder[i] = "0";
                    break;
                case 1:
                    strRemainder[i] = "1";
                    break;
                case 2:
                    strRemainder[i] = "2";
                    break;
                case 3:
                    strRemainder[i] = "3";
                    break;
                case 4:
                    strRemainder[i] = "4";
                    break;
                case 5:
                    strRemainder[i] = "5";
                    break;
                case 6:
                    strRemainder[i] = "6";
                    break;
                case 7:
                    strRemainder[i] = "7";
                    break;
                case 8:
                    strRemainder[i] = "8";
                    break;
                case 9:
                    strRemainder[i] = "9";
                    break;
                case 10:
                    strRemainder[i] = "A";
                    break;
                case 11:
                    strRemainder[i] = "B";
                    break;
                case 12:
                    strRemainder[i] = "C";
                    break;
                case 13:
                    strRemainder[i] = "D";
                    break;
                case 14:
                    strRemainder[i] = "E";
                    break;
                case 15:
                    strRemainder[i] = "F";
                    break;
            }            
        }
        PrintArray(strRemainder);

    }
    static void PrintArray(string[] arr)
    {
        for (int i = 32 - (index + 1); i < 32; i++)
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
        DecToHex(number);
        Console.WriteLine();
    }
}
