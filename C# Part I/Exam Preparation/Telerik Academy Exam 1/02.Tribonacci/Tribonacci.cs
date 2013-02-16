using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.Tribonacci
{
    class Tribonacci
    {
        static void Main(string[] args)
        {
            BigInteger FirstElementT1 = BigInteger.Parse(Console.ReadLine());
            BigInteger SecondElementT2 = BigInteger.Parse(Console.ReadLine());
            BigInteger ThirdElementT3 = BigInteger.Parse(Console.ReadLine());
            BigInteger newElement = 0;
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine(FirstElementT1);
            }
            else if (n == 2)
            {
                Console.WriteLine(SecondElementT2);
            }
            else if (n == 3)
            {
                Console.WriteLine(ThirdElementT3);
            }
            else
            {
                for (int i = 4; i <= n; i++)
                {
                    newElement = FirstElementT1 + SecondElementT2 + ThirdElementT3;
                    FirstElementT1 = SecondElementT2;
                    SecondElementT2 = ThirdElementT3;
                    ThirdElementT3 = newElement;
                }
                Console.WriteLine(newElement);
            }
            
        }
    }
}
