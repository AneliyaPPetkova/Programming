//Write an expression that calculates trapezoid's area by given sides a and b and height h.
using System;

class Program
{
    static void Main()
    {
        Console.Title = "Trapezoid's Area";
        Console.Write("Enter side a: ");
        float SideA = float.Parse(Console.ReadLine());
        Console.Write("Enter side b: ");
        float SideB = float.Parse(Console.ReadLine());
        Console.Write("Enter height h: ");
        float Height = float.Parse(Console.ReadLine());
        float Area = ((SideA + SideB) * Height) / 2;
        Console.WriteLine("Trapezoid's Area is {0}",Area);
    }
}

