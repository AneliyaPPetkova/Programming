using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Binary_Digits_Count
{
    class BinaryDigitsCount
    {
        static void Main(string[] args)
        {
            byte b = byte.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            long[] number = new long[n];
            long[] counter = new long[n];
            int startCount = 0;
            for (int i = 0; i < n; i++)
            {
                number[i] = long.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 63; j >= 0; j--)
                {
                    int mask = 1 << j;
                    long numberAndMask = number[i] & mask;
                    long bit = numberAndMask >> j;
                    if (bit == 1)
                    {
                        startCount = 1;
                    }
                    if ((bit == b) && (startCount == 1))
                    {
                        counter[i]++;
                    } 
                }
                startCount = 0;
                Console.WriteLine(counter[i]);
            }
        }
    }
}
