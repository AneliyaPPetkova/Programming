//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

using System;

class SurfaceOfaTriangle
{
    static void SideAndAltitude(double side, double altitude)
    {
        double area;
        area = 0.5 * side * altitude;
        Console.Write(area);
    }
    static void ThreeSides(double side1, double side2, double side3)
    {
        double i = (side1 + side2 + side3) / 2.0;
        double area = Math.Round(Math.Sqrt(i * (i - side1) * (i - side2) * (i - side3)));
        Console.Write(area);
    }
    static void TwoSidesAndAngle(double side1, double side2, double angle)
    {
        double area;
        area = 0.5 * side1 * side2 * Math.Sin(angle);
        Console.Write(area);
    }
    static void Main()
    {
        Console.WriteLine("Choose which task to solve:");
        Console.WriteLine("- Enter 1 for *Calculate the surface of a triangle by given Side and an altitude to it*");
        Console.WriteLine("- Enter 2 for *Calculate the surface of a triangle by given Three sides*");
        Console.WriteLine("- Enter 3 for *Calculate the surface of a triangle by given Two sides and an angle between them*");
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
                double side;
                double altitude;
                Console.WriteLine("Enter 2 non-negativ numbers :");

                while (true)
                {
                    string input1 = Console.ReadLine();
                    string input2 = Console.ReadLine();
                    if (double.TryParse(input1, out side) && double.TryParse(input2, out altitude) && (side > 0) && (altitude > 0))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid input. Enter 2 non-negativ numbers: ");
                    }
                }
                Console.WriteLine("The surface of a triangle by given Side and an altitude to it is:");
                SideAndAltitude(side, altitude);
                Console.WriteLine();
                break;
            case 2:
                double side1;
                double side2;
                double side3;
                Console.WriteLine("Enter 3 non-negativ numbers :");

                //Check size:
                while (true)
                {
                    string input1 = Console.ReadLine();
                    string input2 = Console.ReadLine();
                    string input3 = Console.ReadLine();
                    if (double.TryParse(input1, out side1) && double.TryParse(input2, out side2) && double.TryParse(input3, out side3) && (side1 > 0) && (side2 > 0) && (side3 > 0))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid input. Enter 3 non-negativ numbers: ");
                    }
                }
                Console.WriteLine("The surface of a triangle by given Three sides is:");
                ThreeSides(side1, side2, side3);
                Console.WriteLine();
                break;
            case 3:
                double sideA;
                double sideB;
                double angle;
                Console.WriteLine("Enter 3 non-negativ numbers :");

                //Check size:
                while (true)
                {
                    string input1 = Console.ReadLine();
                    string input2 = Console.ReadLine();
                    string input3 = Console.ReadLine();
                    if (double.TryParse(input1, out sideA) && double.TryParse(input2, out sideB) && double.TryParse(input3, out angle) && (sideA > 0) && (sideB > 0) && (angle > 0))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid input. Enter 3 non-negativ numbers: ");
                    }
                }
                Console.WriteLine("The surface of a triangle by given Two sides and an angle between them is:");
                TwoSidesAndAngle(sideA, sideB, angle);
                Console.WriteLine();
                break;
               
            default:
                break;
        }
    }
}

