//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".

using System;
using System.Text;

class ReverseString
{
    static string Reverse(string word)
    {
        StringBuilder builder = new StringBuilder();
        for (int i = word.Length - 1; i >= 0; i--)
        {
            builder.Append(word[i]);  
        }
        return builder.ToString();
    }
    static void Main()
    {
        Console.WriteLine("Enter word:");
        string word = Console.ReadLine();
        string newWord = Reverse(word);
        Console.WriteLine("Reversed word:");
        Console.WriteLine(newWord);
    }
}

