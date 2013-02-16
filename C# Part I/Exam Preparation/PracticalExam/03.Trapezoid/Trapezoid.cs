using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Trapezoid
{
    class Trapezoid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 2*n; i++)
            {
                if (i < n + 1)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= 2*n; j++)
                {
                    if (j == n + 1 - i)
                    {
                        Console.Write("*");
                    }
                    else if (j == 2 * n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            
            for (int i = 1; i <= 2*n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
