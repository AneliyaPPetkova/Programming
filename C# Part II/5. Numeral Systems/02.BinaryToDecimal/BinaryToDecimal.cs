//Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    static int BinToDec(string biNumber)
    {
        int power = 1;
        int index = 0;
        int sum = 0;
        for (int i = biNumber.Length - 1; i >= 0; i--)
        {
            if (biNumber[i] == '0')
            {
                index++;
                continue;
            }
            else if(biNumber[i] == '1')
            {
                power = (int)Math.Pow(2, index);
                sum = sum + power;
                index++;
            }                
        }
        return sum; 
    }
    static void Print(int sum)
    {
        Console.WriteLine("Decimal Number is:");
        Console.WriteLine(sum);
    }
    static void Main()
    {
        Console.WriteLine("Enter some Binary number:");
        string biNumber = Console.ReadLine();
        int number = BinToDec(biNumber);
        Print(number);
    }
}

