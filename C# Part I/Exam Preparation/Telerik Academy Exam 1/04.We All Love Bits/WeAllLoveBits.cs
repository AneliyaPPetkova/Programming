using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.Problem_WeAllLoveBits
{
    class WeAllLoveBits
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());   
            long[] numbers = new long[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = long.Parse(Console.ReadLine());
            }
            
            for (int j = 0; j < n; j++)
            {
                long reversedP = 0;
                long pNew = 0;
                int binaryNumberLength = 0;
                long currentNumber = numbers[j];
                long invertedP = ~numbers[j];
                for (int i = 31; i >= 0; i--)
                {
                    long mask = 1 << i;
                    if ((numbers[j] & mask) > 0)
                    {
                        binaryNumberLength = i;
                        break;
                    }
                }
                binaryNumberLength++;
                for (int i = 0; i < 32; ++i)
                {
                    reversedP = reversedP << 1;
                    reversedP = reversedP | (currentNumber & 1);
                    currentNumber = currentNumber >> 1;
                }

                reversedP = reversedP >> (32 - binaryNumberLength);

                pNew = (numbers[j] ^ invertedP) & reversedP;
                Console.WriteLine(pNew);
            }
        }
    }
}