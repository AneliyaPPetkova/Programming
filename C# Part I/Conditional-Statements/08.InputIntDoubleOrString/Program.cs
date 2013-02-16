//Write a program that, depending on the user's choice inputs int, double or string variable.
//If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
//The program must show the value of that variable as a console output. Use switch statement.

using System;

class Program
{
    static void Main()
    {
        Console.Title = "Int, Double or String Variable";
        Console.Write("Int, Double or String Variable? Enter [1] for Int, [2] for Double or [3] for String: ");
        string Choice;
        int IntVariable;
        double DoubleVariable;
        string StringVariable;
        while (true)
        {
            Choice = Console.ReadLine();
            if (Choice == "1" || Choice == "2" || Choice == "3")
            {
                break;
            }
            else
            {
                Console.Write("Invalid Input. Enter [1] for Int, [2] for Double or [3] for String: ");
            }
        }
        switch (Choice)
        {
            case "1":
                Console.Write("Enter Integer Variable: ");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out IntVariable))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid input. Enter Integer Variable: ");
                    }
                }
                IntVariable += 1;
                Console.WriteLine("New Value: {0}",IntVariable);
                break;
            case "2":
                Console.Write("Enter Double Variable: ");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out DoubleVariable))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid input. Enter Double Variable: ");
                    }
                }
                DoubleVariable += 1;
                Console.WriteLine("New Value: {0}", DoubleVariable);
                break;
            case "3":
                Console.Write("Enter String Variable: ");
                StringVariable = Console.ReadLine();
                StringVariable = StringVariable + "*";
                Console.WriteLine("New Value: {0}", StringVariable);
                break;
        }
    }
}

