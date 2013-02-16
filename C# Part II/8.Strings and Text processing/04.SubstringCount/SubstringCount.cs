//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

using System;
using System.Text;

class SubstringCount
{
    static int Search(string text, string word)
    {
        text = text.ToLower();
        int count = 0;
        int index = text.IndexOf(word, 0);
        while (index != -1 && index < text.Length)
        {
            count++;
            index = text.IndexOf(word, index + 1);
        }
        return count;
    }
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();
        Console.WriteLine("Enter substring:");
        string word = Console.ReadLine();
        int count = Search(text, word);
        Console.WriteLine(count);
    }
}

