//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter some Integer Number n = ");
        int n;
        double p;
        double SumP=0;
        double FullSum;
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out n) && (n > 0))
            {
                break;
            }
            else
	        {
                Console.WriteLine("Invalid input. Enter Integer Number: n = ");
	        }
        }
        Console.WriteLine("Now Enter {0} Numbers:",n);
        for (int i = 1; i <= n; i++)
        {
            while (true)
            {
                Console.Write("p{0} = ",i);
                string input = Console.ReadLine();
                if (double.TryParse(input, out p))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Enter Number: p = ");
                }
            }
            SumP = SumP + p; 
        }
        FullSum = n + SumP;
        Console.WriteLine("n + Sum[p] = {0}",FullSum);
    }
}

