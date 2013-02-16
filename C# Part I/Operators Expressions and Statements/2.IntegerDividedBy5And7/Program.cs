//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Integer:");
        int Number = int.Parse(Console.ReadLine());
        bool CheckInteger=((Number % 5 == 0) && (Number % 7 == 0));
        if (CheckInteger)
        {
            Console.WriteLine("The Number can be divided by 5 and 7 at the same time."); 
        }
        else
        {
            Console.WriteLine("The Number can not be divided by 5 and 7 at the same time."); 
        }
    }
}

