//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 

using System;

class StringToUnicode
{
    static void Main()
    {
        Console.WriteLine("Enter string:");
        string text = Console.ReadLine();
        ushort[] convertText = new ushort[text.Length];
        ushort[] unicode = new ushort[text.Length];
        Console.WriteLine();
        Console.WriteLine("String \"{0}\" to a sequence of C# Unicode character literals:",text);
        for (int i = 0; i < text.Length; i++)
        {
            convertText[i] = (ushort)text[i];
            Console.Write("\\u{0:x4}", convertText[i]);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

