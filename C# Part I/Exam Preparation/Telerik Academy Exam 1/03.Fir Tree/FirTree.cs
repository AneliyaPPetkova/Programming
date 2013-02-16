using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fir_Tree
{
    class FirTree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 2*(n - 1) - 1; i++)
            {
                if (i == (n - 1))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
                
            }
            Console.WriteLine();
            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 1; j < (n - i - 1); j++)
                {
                    Console.Write(".");
                }
                for (int k = n - i; k <= n + i; k++)
                {
                    Console.Write("*");
                }
                for (int l = n + i; l <= 2*(n - 1) - 1; l++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= 2 * (n - 1) - 1; i++)
            {
                if (i == (n - 1))
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
    }
}
