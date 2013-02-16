//We are given a string containing a list of forbidden words and a text
//containing some of these words. Write a program that replaces the forbidden words with asterisks. 

using System;

class ForbiddenWords
{
    static void Search(string text, string[] forbidden)
    {
       
        string word;
        string textToLower = text.ToLower();
        for (int i = 0; i < forbidden.Length; i++)
        {
            word = forbidden[i].Trim();
            text = text.Replace(word, "*".PadLeft(word.Length,'*'));
        }
        Console.WriteLine(text);
    }
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();
        Console.WriteLine("Enter list of forbidden words, separated by commas:");
        string list = Console.ReadLine();
        string[] forbiddenWords= list.Split(',');
        Console.WriteLine();
        Search(text, forbiddenWords);
    }
}

