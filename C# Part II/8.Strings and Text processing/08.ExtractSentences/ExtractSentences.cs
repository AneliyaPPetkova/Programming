//Write a program that extracts from a given text all sentences containing given word.
//Consider that the sentences are separated by "." and the words – by non-letter symbols.

using System;

class ExtractSentences
{
    static void Search(string text, string word)
    {
        string[] sentences = text.Split('.');
        string sent;
        for (int i = 0; i < sentences.Length; i++)
        {
            sent = sentences[i].ToLower();
          
            int index = sent.IndexOf(" " + word + " ");
            if (index > -1)
            {
                Console.WriteLine(sentences[i].Trim() + ".");
            }
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();
        Console.WriteLine("Enter substring:");
        string word = Console.ReadLine();
        Console.WriteLine();
        Search(text, word);
    }
}

