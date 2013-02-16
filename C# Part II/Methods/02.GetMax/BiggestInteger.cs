//Write a method GetMax() with two parameters that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

class BiggestInteger
{
    static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber >= secondNumber)
        {
            return firstNumber;
        }
        else
        {
            return secondNumber;
        }

    }
    static void Main()
    {
        Console.WriteLine("Enter 3 integers:");
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int compare12 = GetMax(firstNumber, secondNumber);
        int biggest = GetMax(compare12, thirdNumber);
        Console.WriteLine("The biggest of 3 integers is {0}", biggest );
    }
}

