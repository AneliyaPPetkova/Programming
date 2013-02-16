//We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.

using System;

class Program
{
    static void Main()
    {
        Console.Title = "Exchange Value of the Bit";
        Console.Write("Enter the Number: ");
        int NumberV = int.Parse(Console.ReadLine());
        Console.Write("Enter the Position of The Bit: ");
        int Position = int.Parse(Console.ReadLine());
        Console.Write("Enter the Value of The Bit: ");
        int Value;
        while (true)
        {
            Value = int.Parse(Console.ReadLine());
            if ((Value == 1) || (Value == 0))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Value. Enter the Value of The Bit again, please:");
                continue;
            }
        }
        Console.WriteLine("This is the Binary Number:  {0}",Convert.ToString(NumberV, 2).PadLeft(32, '0'));    
        if (Value == 1)
        {
            int maskValue1 = 1 << Position;         
            int result = NumberV | maskValue1;
            Console.WriteLine("This is the New Binary Number:  {0}",Convert.ToString(result, 2).PadLeft(32, '0'));    
            Console.WriteLine(result);  
        }
        else
        {
            int maskValue2 = ~(1 << Position);    
            int result2 = NumberV & maskValue2;
            Console.WriteLine("This is the New Binary Number:  {0}", Convert.ToString(result2, 2).PadLeft(32, '0')); 
            Console.WriteLine(result2);  
        }
    }
}
