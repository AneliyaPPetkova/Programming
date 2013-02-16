//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//		Create appropriate methods.
//		Provide a simple text-based menu for the user to choose which task to solve.
//		Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;

class ChooseTaskToSolve
{
    static void Reverse(int number, int length)
    {
        int remainder;
        for (int i = 0; i < length; i++)
        {
            remainder = number % 10;
            number = number / 10;
            Console.Write(remainder);
        }

    }
    static void Average(int[] array)
    {
        double sum = 0;
        double average;
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }
        average = sum / array.Length;
        Print(array);
        Console.WriteLine();
        Console.WriteLine("The average of a sequence of this integers is: {0}", average);
    }
    static void LinearEquation(double a, double b)
    {
        double x = (-b) / a;
        Console.WriteLine("X = {0}", x);
    }
    static void Print(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
    static void Main()
    {
        Console.WriteLine("Choose which task to solve:");
        Console.WriteLine("- Enter 1 for *Reverses the digits of a number*");
        Console.WriteLine("- Enter 2 for *Calculates the average of a sequence of integers*");
        Console.WriteLine("- Enter 3 for *Solves a linear equation a * x + b = 0*");
        int task;
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out task) && (task == 1) || (task == 2) || (task == 3))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter 1 or 2 or 3: ");
            }
        }
        Console.WriteLine();
        switch (task)
        {
            case 1:
                int number;
                int length;
                Console.WriteLine("Enter some non-negativ decimal number :");

                //Check size:
                while (true)
                {
                    string input = Console.ReadLine();
                    length = input.Length;
                    if (int.TryParse(input, out number) && (length > 0) && (number > 0))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid input. Enter some non-negativ decimal number: ");
                    }
                }
                Console.WriteLine("Reversed number:");
                Reverse(number, length);
                Console.WriteLine();
                break;
            case 2:
                Console.WriteLine("Enter number of integers:");
                int size;
                //Check size:
                while (true)
                {
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out size) && (size > 0))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid input. Enter integer number: ");
                    }
                }
                Console.WriteLine("Enter {0} integers:", size);
                int[] arr = new int[size];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                Average(arr);
                Console.WriteLine();
                break;
            case 3:
                Console.WriteLine("Enter coefficients a != 0 and b of the linear equation:");
                double a;
                double b;
                //Check size:
                while (true)
                {
                    string inputA = Console.ReadLine();
                    string inputB = Console.ReadLine();
                    if (double.TryParse(inputA, out a) && double.TryParse(inputB, out b) && (a != 0))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid input. Enter coefficients a != 0 and b of the linear equation:: ");
                    }
                }
                LinearEquation(a, b);
                break;
            default:
                break;
        }
    }
}

