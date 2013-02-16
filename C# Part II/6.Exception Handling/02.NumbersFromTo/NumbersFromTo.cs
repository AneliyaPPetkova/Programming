//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//If an invalid number or non-number text is entered, the method should throw an exception. 
//Using this method write a program that enters 10 numbers:
//			a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class NumbersFromTo
{
    static int number;
    static int counterExceptions = 0;
    static int ifCatch = 0;
    static void NumberNotInRange(int number, int start, int end)
    {
        if ((number < start) || (number > end))
        {
            Exception NotInRange = new Exception("Number out of range!");
            throw NotInRange;
        }
    }
    static void ReadNumber(int start, int end)
    {
        ifCatch = 0;
        Console.WriteLine("Enter integer number:");
        try
        {
            number = int.Parse(Console.ReadLine());
            try
            {
                NumberNotInRange(number, start, end);
                Console.WriteLine("{0} < {1} < {2}", start, number, end);
            }
            catch (Exception range)
            {
                Console.WriteLine();
                Console.WriteLine("Number {0} is not in range [{1},{2}]!" + range.Message, number, start, end);
                counterExceptions++;
                ifCatch = 1;
            }            
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number is too big to fit in Int32!");
            counterExceptions++;
            ifCatch = 1;
        }
        catch (FormatException)
        {
            Console.WriteLine("This is not a integer number!");
            counterExceptions++;
            ifCatch = 1;
        }
    }
    static void Main()
    {
        int start = 1;
        int end = 100;
        for (int i = 0; i < 10 + counterExceptions; i++)
        {
            ReadNumber(start, end);
            if (ifCatch == 0)
            {
                start = number;
            }
            
        }
    }
}

