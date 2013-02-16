//Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.

using System;

class Program
{
    static void Main()
    {
        Console.Title = "Name of a Digit";
        int DigitNumber;
        Console.Write("Enter a Digit[0-9]: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out DigitNumber) && (DigitNumber >= 0) && (DigitNumber < 9))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Digit[0-9]: ");
            }
        }
        
        switch (DigitNumber)
        {
            case 0:
                Console.WriteLine("{0} -> [zero]", DigitNumber);
                break;
            case 1:
                Console.WriteLine("{0} -> [one]",DigitNumber);
                break;
            case 2:
                Console.WriteLine("{0} -> [two]", DigitNumber);
                break;
            case 3:
                Console.WriteLine("{0} -> [three]", DigitNumber);
                break;
            case 4:
                Console.WriteLine("{0} -> [four]", DigitNumber);
                break;
            case 5:
                Console.WriteLine("{0} -> [five]", DigitNumber);
                break;
            case 6:
                Console.WriteLine("{0} -> [six]", DigitNumber);
                break;
            case 7:
                Console.WriteLine("{0} -> [seven]", DigitNumber);
                break;
            case 8:
                Console.WriteLine("{0} -> [eight]", DigitNumber);
                break;
            case 9:
                Console.WriteLine("{0} -> [nine]", DigitNumber);
                break;
        }

    }
}

