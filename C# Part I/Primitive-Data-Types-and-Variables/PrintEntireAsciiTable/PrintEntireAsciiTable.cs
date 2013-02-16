using System;

class PrintEntireAsciiTable
{
    static void Main()
    {
        Console.WriteLine(new string('-',40));
        Console.Write("Dec".PadRight(10));
        Console.Write("Hex".PadRight(10));
        Console.WriteLine("Char".PadRight(10));
        Console.WriteLine(new string('-', 40));
        for (int dec = 0; dec < 128; dec++)
        {
            
            string hex = dec.ToString("X");
            char chr = (char)dec;
            Console.Write(dec.ToString().PadRight(10));
            Console.Write(hex.PadRight(10));
            Console.WriteLine(chr.ToString().PadRight(10));
        }
    }
}

