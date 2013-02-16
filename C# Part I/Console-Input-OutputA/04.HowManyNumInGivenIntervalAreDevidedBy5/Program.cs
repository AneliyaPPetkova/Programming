//Write a program that reads two positive integer numbers and prints how many numbers p
//exist between them such that the reminder of the division by 5 is 0 (inclusive). 
//Example: p(17,25) = 2.

using System;

class Program
{
    static void Main()
    {
        
        int FirstNumber;
        int SecondNumber;
        int Smaller;
        int Bigger;
        int p = 0;
        int OtherNum=0;
        Console.WriteLine("Enter First Positive Integer Number:");
        while (true)
        {
            FirstNumber = int.Parse(Console.ReadLine());
            if (FirstNumber > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Enter positive integer:");  
            }
        }
        Console.WriteLine("Enter Second Positive Integer Number:");
        while (true)
        {
            SecondNumber = int.Parse(Console.ReadLine());
            if (SecondNumber > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Enter positive integer:");
                continue;
            }
        }
        if (FirstNumber > SecondNumber)
        {
            Bigger = FirstNumber;
            Smaller = SecondNumber;
        }
        else
        {
            Smaller = FirstNumber;
            Bigger = SecondNumber;
        }
        for (int i = Smaller; i <= Bigger; i++)
        {
            if (i % 5 == 0)
            {
                p++;
            }
            else
            {
                OtherNum++;
            }
        }
        Console.WriteLine("In the Interval [{0};{1}] exist {2} Numbers, which can be divided by 5 without reminder and {3} Other Integer Numbers.",Smaller,Bigger,p,OtherNum);
    }
}

