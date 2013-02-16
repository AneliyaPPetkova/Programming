//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

class Program
{
    static void Main()
    {
        Console.Title = "Point in a Circle K(0,5)";
        Console.Write("Enter X Coordinate of the Number: ");
        float XCoordinate = float.Parse(Console.ReadLine());
        Console.Write("Enter Y Coordinate of the Number: ");
        float YCoordinate = float.Parse(Console.ReadLine());
        float Pitagor = (float)Math.Sqrt((XCoordinate * XCoordinate) + (YCoordinate * YCoordinate));
        if (Pitagor <= 5.0)
        {
            Console.WriteLine("This Point is in the Circle"); 
        }
        else
        {
            Console.WriteLine("This Point is Not in the Circle");
        }
    }
}

