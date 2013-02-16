using System;

class ComparesNumbers
{
    static void Main()
    {
        Console.Write("Enter first floating-point number:");
        decimal firstNum = decimal.Parse(Console.ReadLine());
        Console.Write("Enter second floating-point number:");
        decimal secondNum = decimal.Parse(Console.ReadLine());
        decimal subtraction=Math.Abs((firstNum)-(secondNum));

        decimal precision = 0.000001m;
        bool equal=(subtraction<=precision);
        Console.WriteLine(equal);
    }
}

