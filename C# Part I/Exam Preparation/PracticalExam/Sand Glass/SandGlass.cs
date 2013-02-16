using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sand_Glass
{
    class SandGlass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = (n / 2); i >= 1; i--)
            {
                for (int j = 1; j < (n / 2) - i + 1; j++)
                {
                    Console.Write(".");
                }
                for (int j = (n / 2) - i; j < (n / 2) + i + 1; j++)
                {
                    Console.Write("*");
                }
                for (int j = (n / 2) + i + 1; j < n; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= n; i++)
            {
                if (i == (n/2) +1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
            for (int i = 1; i <= (n / 2); i++)
            {
                for (int j = 1; j < (n/2) - i + 1; j++)
                {
                    Console.Write(".");
                }
                for (int j = (n/2) - i; j < (n/2) + i + 1; j++)
                {
                    Console.Write("*");
                }
                for (int j = (n/2) + i + 1; j < n; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
        }
    }
}
