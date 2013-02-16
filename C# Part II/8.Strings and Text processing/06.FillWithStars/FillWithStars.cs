//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters 
//should be filled with '*'. Print the result string into the console.

using System;
using System.Text;

class FillWithStars
{
    static void Main()
    {
        Console.WriteLine("Enter Text with maximum 20 characters:");
        string text;
        while (true)
        {
            text = Console.ReadLine();
            if (text.Length <= 20)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Enter Text with maximum 20 characters:");
            }  
        }
        Console.WriteLine();
        Console.WriteLine("Changed Text:");
        Console.WriteLine(text.PadRight(20, '*'));
        Console.WriteLine();
    }
}
