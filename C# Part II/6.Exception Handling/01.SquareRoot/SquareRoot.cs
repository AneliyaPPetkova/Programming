//Write a program that reads an integer number and calculates and prints its square root. 
//If the number is invalid or negative, print "Invalid number". 
//In all cases finally print "Good bye". Use try-catch-finally.

using System;
class SquareRoot
{
    static void NegativeNumberException(int number)
    {
        if (number < 0)
        {
            Exception NegativeNumber = new Exception("Negative number!");
            throw NegativeNumber;
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter integer number:");
        try
        {
            int number = int.Parse(Console.ReadLine());
            try
            {
                NegativeNumberException(number);
                double root = Math.Sqrt(number);
                Console.WriteLine("Square root of {0} is: {1}", number, root);
            }
            catch (Exception Negative)
            {
                Console.WriteLine();
                Console.WriteLine(Negative.Message); 
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number is too big to fit in Int32!");
            
        }
        catch (FormatException)
        {
            Console.WriteLine("This is not a number!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }

    }
}

