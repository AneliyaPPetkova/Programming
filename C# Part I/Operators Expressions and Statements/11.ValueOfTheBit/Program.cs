//Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.

using System;

class Program
{
    static void Main()
    {
        Console.Title = "Value of the Bit";
        Console.Write("Enter the Number: ");
        int NumberV = int.Parse(Console.ReadLine());
        Console.Write("Enter the Position of The Bit: ");
        int Position = int.Parse(Console.ReadLine());
        int mask = 1 << Position;
        int NumberAndMask = NumberV & mask;
        int bit = NumberAndMask >> Position;
        Console.WriteLine(Convert.ToString(NumberV, 2).PadLeft(32, '0'));
        Console.WriteLine("The Value of The Bit at position {0} is {1}.",Position,bit);
    }
}

