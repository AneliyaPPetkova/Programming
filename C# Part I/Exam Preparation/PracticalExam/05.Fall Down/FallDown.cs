using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fall_Down
{
    class FallDown
    {
        static void Main(string[] args)
        {
            int n0 = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            int n6 = int.Parse(Console.ReadLine());
            int n7 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j <= 7; j++)
                {
                    if (((n7 & (1 << j)) >> j) == 0 && ((n6 & (1 << j)) >> j) == 1)
                    {
                        n7 |= (1 << j);
                        n6 &= ~(1 << j);
                    }
                }
                for (int j = 0; j <= 7; j++)
                {
                    if (((n6 & (1 << j)) >> j) == 0 && ((n5 & (1 << j)) >> j) == 1)
                    {
                        n6 |= (1 << j);
                        n5 &= ~(1 << j);
                    }
                }
                for (int j = 0; j <= 7; j++)
                {
                    if (((n5 & (1 << j)) >> j) == 0 && ((n4 & (1 << j)) >> j) == 1)
                    {
                        n5 |= (1 << j);
                        n4 &= ~(1 << j);
                    }
                }
                for (int j = 0; j <= 7; j++)
                {
                    if (((n4 & (1 << j)) >> j) == 0 && ((n3 & (1 << j)) >> j) == 1)
                    {
                        n4 |= (1 << j);
                        n3 &= ~(1 << j);
                    }
                }
                for (int j = 0; j <= 7; j++)
                {
                    if (((n3 & (1 << j)) >> j) == 0 && ((n2 & (1 << j)) >> j) == 1)
                    {
                        n3 |= (1 << j);
                        n2 &= ~(1 << j);
                    }
                }
                for (int j = 0; j <= 7; j++)
                {
                    if (((n2 & (1 << j)) >> j) == 0 && ((n1 & (1 << j)) >> j) == 1)
                    {
                        n2 |= (1 << j);
                        n1 &= ~(1 << j);
                    }
                }
                for (int j = 0; j <= 7; j++)
                {
                    if (((n1 & (1 << j)) >> j) == 0 && ((n0 & (1 << j)) >> j) == 1)
                    {
                        n1 |= (1 << j);
                        n0 &= ~(1 << j);
                    }
                }
                
            }
            Console.WriteLine(n0);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(n7);
        }
    }
}
