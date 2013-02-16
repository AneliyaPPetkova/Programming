//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class Program
{
    static void Main()
    {
        Console.Title = "Exchange Bits 3,4,5 With Bits 24,25,26";
        Console.Write("Enter the Number: ");
        int NumberV = int.Parse(Console.ReadLine());
        Console.WriteLine("This is the Binary Number:  {0}", Convert.ToString(NumberV, 2).PadLeft(32, '0'));
        int bit3 = ((NumberV & (1 << 3)) >> 3);
        int bit4 = ((NumberV & (1 << 4)) >> 4);
        int bit5 = ((NumberV & (1 << 5)) >> 5);
        int bit24 = ((NumberV & (1 << 24)) >> 24);
        int bit25 = ((NumberV & (1 << 25)) >> 25);
        int bit26 = ((NumberV & (1 << 26)) >> 26);
        int NumberMask = (NumberV & ( ~(1 << 3)));
        NumberMask = (NumberMask & (~(1 << 4)));
        NumberMask = (NumberMask & (~(1 << 5)));
        NumberMask = (NumberMask & (~(1 << 24)));
        NumberMask = (NumberMask & (~(1 << 25)));
        NumberMask = (NumberMask & (~(1 << 26)));
        int NewNumber = (NumberMask | (bit3 << 24));
        NewNumber = (NewNumber | (bit4 << 25));
        NewNumber = (NewNumber | (bit5 << 26));
        NewNumber = (NewNumber | (bit24 << 3));
        NewNumber = (NewNumber | (bit25 << 4));
        NewNumber = (NewNumber | (bit26 << 5));
        Console.WriteLine("This is the New Binary Number:  {0}", Convert.ToString(NewNumber, 2).PadLeft(32, '0'));
        Console.WriteLine(NewNumber);
    }
}

