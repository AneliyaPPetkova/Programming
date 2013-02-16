//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

class LeapYear
{
    static void Leap(int year)
    {
        int nowYear = DateTime.Now.Year;
        bool isLeap = DateTime.IsLeapYear(year);
        string answer;
        if (isLeap == true)
        {
            answer = "yes";
        }
        else
        {
            answer = "no";
        }
        if (year < nowYear)
        {
            Console.WriteLine("Was {0} a leap year: {1}", year, answer);
        }
        else if (year == nowYear)
        {
            Console.WriteLine("Is {0} leap year: {1}",year,answer);
        }
        else
        {
            Console.WriteLine("Will {0} be a leap year: {1}", year, answer);
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter year:");
        int year;
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out year) && (year > 0))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter year: ");
            }
        }
        
        Leap(year);

    }
}

