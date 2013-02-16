//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class Program
{
    static void Main()
    {
        Console.Title="The Bit of a Number";
        Console.Write("Enter the Number: ");
        int NumberV = int.Parse(Console.ReadLine());
        int mask = 1 << 3;
        int NumberAndMask = NumberV & mask;
        int bit = NumberAndMask >> 3;
        bool CheckTheBit = (bit == 1);
        if (CheckTheBit)
        {
            Console.WriteLine("The Bit at Position 3 is 1"); 
        }
        else
        {
            Console.WriteLine("The Bit at Position 3 is 0");
        }
    }
}

