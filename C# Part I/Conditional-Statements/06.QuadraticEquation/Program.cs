//Write a program that enters the coefficients a, b and c of a quadratic equation
//	a*x2 + b*x + c = 0
//and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

using System;

class Program
{
    static void Main()
    {
        float a;
        float b;
        float c;
        Console.Write("Enter Coefficient a: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (float.TryParse(input, out a))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Number: ");
            }
        }
        Console.Write("Enter Coefficient b: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (float.TryParse(input, out b))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Number: ");
            }
        }
        Console.Write("Enter Coefficient c: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (float.TryParse(input, out c))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Number: ");
            }
        }
        if (a == 0)
        {
            Console.WriteLine("This is not quadratic equation: x = {0}", ((-c) / b));
        }
        if (b == 0)
        {
            Console.WriteLine("x = {0}", Math.Sqrt(-c / a));
        }
        if ((a != 0) && (b != 0))
        {
            double D = b * b - 4 * a * c;
            if (D > 0)
            {
                Console.WriteLine("X1 = {0}", ((-b - Math.Sqrt(D)) / (2 * a)));
                Console.WriteLine("X2 = {0}", ((-b + Math.Sqrt(D)) / (2 * a)));
            }
            if (D == 0)
            {
                Console.WriteLine("X1 = X2 = {0}", (-b / (2 * a)));
            }
            if (D < 0)
            {
                Console.WriteLine("There is No Solution");
            }
        }
    }
}

