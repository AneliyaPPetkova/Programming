//Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class Program
{
    static void Main()
    {
        Console.Title = "Perimeter and Area of a Circle";
        Console.WriteLine("Enter Radius r of a circle:");
        double Radius;
        while (true)
        {
            Radius = double.Parse(Console.ReadLine());
            if (Radius > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Enter Radius again:");
                continue;
            }
        }
        double Perimeter = 2 * Math.PI * Radius;
        double Area = Math.Pow(Radius, 2) * Math.PI;
        Console.WriteLine("Perimeter of a circle with radius {0} is {1}",Radius,Perimeter);
        Console.WriteLine("Area of a circle with radius {0} is {1}",Radius,Area);
    }
}
