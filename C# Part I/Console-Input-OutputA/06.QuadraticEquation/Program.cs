//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Coefficient a: ");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter Coefficient b: ");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter Coefficient c: ");
        float c = float.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("This is not quadratic equation: x = {0}",((-c)/b));
        }
        if (b == 0)
        {
            Console.WriteLine("x = {0}",Math.Sqrt(-c/a));
        }
        if ((a != 0) && (b != 0))
        {
            double D = b*b-4*a*c;
            if (D > 0)
            {
                Console.WriteLine("X1 = {0}",((-b - Math.Sqrt(D))/(2 * a)));
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

