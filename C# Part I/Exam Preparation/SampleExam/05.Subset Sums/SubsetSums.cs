using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Subset_Sums
{
    class SubsetSums
    {
        static void Main(string[] args)
        {
            
            int counter = 0;
            int pow = 1;
            long s = long.Parse(Console.ReadLine());
            int numbers = int.Parse(Console.ReadLine());
            long[] arrayWithNNumbers = new long[numbers];
            for (int i = 0; i < numbers; i++)
            {
                arrayWithNNumbers[i] = long.Parse(Console.ReadLine());
            }
            pow = (int)Math.Pow(2, numbers) - 1;
            for (int i = 1; i <= pow; i++)
            {
                long sum = 0;
                for (int j = 0; j < numbers; j++)
                {
                    int mask = 1 << j;
                    int nAndMask = i & mask;
                    int bit = nAndMask >> j;
                    if (bit == 1)
                    {
                        sum += arrayWithNNumbers[j];
                    }  
                }
                if (sum == s)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
