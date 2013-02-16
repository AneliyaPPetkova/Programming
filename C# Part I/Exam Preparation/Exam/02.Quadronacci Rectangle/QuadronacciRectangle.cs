using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Quadronacci_Rectangle
{
    class QuadronacciRectangle
    {
        static void Main(string[] args)
        {
            long number1 = long.Parse(Console.ReadLine());
            long number2 = long.Parse(Console.ReadLine());
            long number3 = long.Parse(Console.ReadLine());
            long number4 = long.Parse(Console.ReadLine());
            long r = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long newNumber;
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= c/4; j++)
                {
                    Console.Write("{0} ", number1);
                    Console.Write("{0} ", number2);
                    Console.Write("{0} ", number3);
                    Console.Write("{0}", number4);
                    newNumber = number1 + number2 + number3 + number4;
                    number1 = newNumber;
                    newNumber = number1 + number2 + number3 + number4;
                    number2 = newNumber;
                    newNumber = number1 + number2 + number3 + number4;
                    number3 = newNumber;
                    newNumber = number1 + number2 + number3 + number4;
                    number4 = newNumber;
                    if (j != c / 4)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
