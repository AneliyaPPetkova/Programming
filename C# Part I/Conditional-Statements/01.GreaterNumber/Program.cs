//Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

using System;

class Program
{
    static void Main()
    {
        int FirstVariable;
        int SecondVariable;
        Console.Write("Enter First Integer Variable:");
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out FirstVariable))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Integer Number: ");
            }
        }
        Console.Write("Enter Second Integer Variable:");
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out SecondVariable))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Integer Number: ");
            }
        }
        if (FirstVariable > SecondVariable)
        {
            int Exchange;
            Exchange = FirstVariable;
            FirstVariable = SecondVariable;
            SecondVariable = Exchange;
            Console.WriteLine("{0} < {1}",FirstVariable,SecondVariable);
        }
        else
        {
            Console.WriteLine("{0} < {1}", FirstVariable, SecondVariable);
        }
    }
}

