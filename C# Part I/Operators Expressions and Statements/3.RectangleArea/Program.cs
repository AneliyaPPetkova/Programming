//Write an expression that calculates rectangle’s area by given width and height.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Rectangle's Area");
        Console.Write("Enter Width Of the Rectangle: ");
        float Width = float.Parse(Console.ReadLine());
        Console.Write("Enter Height Of the Rectangle: ");
        float Height = float.Parse(Console.ReadLine());
        if (Width>0 && Height>0)
        {
            float Area;
            Area = ((Width) * (Height));
            Console.WriteLine("Rectangle's Area is: {0}",Area);
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}

