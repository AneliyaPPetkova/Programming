//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class Program
{
    static void Main()
    {
        Console.Title = "Sum With Accuracy of 0.001";
        double LastSum = 0;
        double FullSum = 1;
        int i = 1;
        double AbsoluteSum;
        for (double n = 2; ; n++)
        {
            FullSum = FullSum + (1 / n*i);
            i = i*(-1);
            AbsoluteSum = Math.Abs(FullSum - LastSum);
            if (AbsoluteSum < 0.001)
            {
                Console.WriteLine("Sum(with accuracy of 0.001) Of 1+1/2-1/3+1/4-1/5+... is {0}", FullSum);
                break;
            }
            LastSum = FullSum;
        }
    }
}

