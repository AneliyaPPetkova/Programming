using System;

class HexadecimalFormat
{
    static void Main()
    {
        int numberInDec = 254;
        string numberInHex = numberInDec.ToString("X");
        Console.WriteLine("The Number 254 in Hexadecimal Format is:{0}",numberInHex);
    }
}

