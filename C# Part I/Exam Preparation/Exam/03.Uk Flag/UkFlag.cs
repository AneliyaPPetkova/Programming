using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Uk_Flag
{
    class UkFlag
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n/2; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j == ((n / 2) + 1))
                    {
                        Console.Write("|");
                    }
                    else if (j == i + 1)
                    {
                        Console.Write("\\");
                    }
                    else if (j == n - i)
                    {
                        Console.Write("/");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= n; i++)
            {
                if (i == ((n / 2) + 1))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine();
            for (int i = ((n / 2) - 1); i >= 0; i--)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j == ((n / 2) + 1))
                    {
                        Console.Write("|");
                    }
                    else if (j == i + 1)
                    {
                        Console.Write("/");
                    }
                    else if (j == n - i)
                    {
                        Console.Write("\\");
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
}
