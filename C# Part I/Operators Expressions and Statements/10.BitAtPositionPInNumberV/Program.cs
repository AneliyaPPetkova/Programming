//Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1.
//Example: v=5; p=1  false.
using System;

class Program
{
    static void Main()
    {
        Console.Title = "Boolean  Expression that Returns if The Bit at Position P in a Number has Value 1";
        Console.Write("Enter the Number: ");
        int NumberV = int.Parse(Console.ReadLine());
        Console.Write("Enter the Position of The Bit: ");
        int Position = int.Parse(Console.ReadLine());
        int mask = 1 << Position;
        int NumberAndMask = NumberV & mask;
        int bit = NumberAndMask >> Position;
        bool CheckTheBit = (bit == 1);
        Console.WriteLine(CheckTheBit);
    }
}

