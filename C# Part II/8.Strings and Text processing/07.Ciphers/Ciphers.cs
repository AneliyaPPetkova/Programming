//Write a program that encodes and decodes a string using given encryption key (cipher). 
//The key consists of a sequence of characters. The encoding/decoding is done by performing 
//XOR (exclusive or) operation over the first letter of the string with the first of the key, 
//the second – with the second, etc. When the last key character is reached, the next is the first.

using System;

class Ciphers
{
    static void Main()
    {
        Console.WriteLine("Enter word for encoding:");
        string text = Console.ReadLine();
        Console.WriteLine("Enter encryption key:");
        string key = Console.ReadLine();
        ushort[] convertText = new ushort[text.Length];
        ushort[] convertKey = new ushort[key.Length];
        ushort[] encrypt = new ushort[text.Length];
        int index = 0;
        Console.WriteLine();
        Console.WriteLine("Encoded string:");
        for (int i = 0; i < key.Length; i++)
        {
            convertKey[i] = (ushort)key[i];
        }
        for (int i = 0; i < text.Length; i++)
        {
            convertText[i] = (ushort)text[i];
            encrypt[i] = (ushort)(convertText[i] ^ convertKey[index]);
            index++;
            if (index == convertKey.Length)
            {
                index = 0;
            }
            Console.Write("\\u{0:x4}",encrypt[i]);
        }
        Console.WriteLine();
    }
}

