//* Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

using System;

class Program
{
    static void Main()
    {
        Console.Title = "Exchange Bits {p, p+1, …, p+k-1) with Bits {q, q+1, …, q+k-1}";
        int Number;
        int k;
        int p;
        int q;
        int BitP = 0;
        int BitQ = 0;
        Console.Write("Enter the Number: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out Number) && Number > 0)
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter Positive Integer Number: ");
            }
        }
        Console.WriteLine("Enter q((q + k) <= 32), p(p<q) and k(How Many Bits Would You Like to Exchange): ");
        while (true)
        {
            Console.Write("q = ");
            bool input1 = int.TryParse(Console.ReadLine(), out q);
            Console.Write("p = ");
            bool input2 = int.TryParse(Console.ReadLine(), out p);
            Console.Write("k = ");
            bool input3 = int.TryParse(Console.ReadLine(), out k);
            if (input1 && input2 && input3 && (p > 0) && (q > 0) && (k > 0) && p < q && ((q + k) <= 32))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. q, p and k again: ");
            }
        }
        Console.WriteLine("This is the Binary Number:  {0}", Convert.ToString(Number, 2).PadLeft(32, '0'));
        for (int i = p; i <= (p + k - 1); i++)
        {
            BitP = (Number & (1 << i)) | BitP;
            Number = (Number & (~(1 << i)));    
        }
        for (int n = q; n <= (q + k - 1); n++)
        {
            BitQ = (Number & (1 << n)) | BitQ;
            Number = (Number & (~(1 << n)));   
        }
        Number = (Number | (BitP << (q - p)));
        Number = (Number | (BitQ >> (q - p)));
        Console.WriteLine();
        Console.WriteLine("This is the New Binary Number:  {0}", Convert.ToString(Number, 2).PadLeft(32, '0'));
        
    }
}

