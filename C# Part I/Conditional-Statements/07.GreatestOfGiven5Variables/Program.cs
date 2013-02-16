//Write a program that finds the greatest of given 5 variables.

using System;

class Program
{
    static void Main()
    {
        Console.Title = "Greatest Of Given 5 Variables";
        double A;
        double B;
        double C;
        double D;
        double E;
        double X;
        Console.Write("Enter First Number: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out A))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Number: ");
            }
        }
        Console.Write("Enter Second Number: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out B))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Number: ");
            }
        }
        Console.Write("Enter Third Number: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out C))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Number: ");
            }
        }
        Console.Write("Enter Fourth Number: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out D))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Number: ");
            }
        }
        Console.Write("Enter Fifth Number: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out E))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Number: ");
            }
        }
        for (int i = 0; i < 5; i++)
        {
            if (A > B)
            {
                X = A;
                A = B;
                B = X;
            }
            if (B > C)
            {
                X = B;
                B = C;
                C = X;
            }
            if (C > D)
            {
                X = C;
                C = D;
                D = X;
            }
            if (D > E)
            {
                X = D;
                D = E;
                E = X;
            }
        }
        Console.WriteLine(" The Greatest Variable is {0}",E);
    }
}

