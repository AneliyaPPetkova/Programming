//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

using System;

class Program
{
    static void Main()
    {
        Console.Title="Check if the Third Digit of a Number is 7";
        Console.WriteLine("Enter Integer:");
        int Number = int.Parse(Console.ReadLine());
        int Check = Number / 100;
        if (Check % 10 == 7)
        {
            Console.WriteLine("The Third Digit of the Number is 7");  
        }
        else
        {
            Console.WriteLine("The Third Digit of a Number is not 7");
        }
      
    }
}

