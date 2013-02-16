//Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class Program
{
    static void Main()
    {
        Console.Title = "Point in a Circle K((1,1),3)";
        Console.Write("Enter X Coordinate of the Number: ");
        float XCoordinate = float.Parse(Console.ReadLine());
        Console.Write("Enter Y Coordinate of the Number: ");
        float YCoordinate = float.Parse(Console.ReadLine());
        float Pitagor = (float)Math.Sqrt(((XCoordinate-1) * (XCoordinate-1)) + ((YCoordinate-1) * (YCoordinate-1)));
        if (Pitagor <= 3.0)
        {
            if (XCoordinate<=-1 || YCoordinate<=-1 || YCoordinate>1)
	        {
                Console.WriteLine("This Point is in the Circle and Out Of The Rectangle.");
	        }
            else
            {
                Console.WriteLine("This Point is in the Circle and in The Rectangle.");      
            }
        }
        else
        {
            if (XCoordinate>=-1 && XCoordinate<=5 && YCoordinate>=-1 && YCoordinate<=1)
            {
                 Console.WriteLine("This Point is Out Of the Circle, but in the Rectangle");   
            }
            else
            {
                Console.WriteLine("This Point is Out of the Circle and Out of the Rectangle");
            }
            
        }
    }
}

