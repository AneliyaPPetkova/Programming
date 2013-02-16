using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Odd_Number
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long oddNumber = 0;
            for (int i = 1; i <= n; i++)
            {
                long number = long.Parse(Console.ReadLine());
                oddNumber ^= number;
            }
            Console.WriteLine(oddNumber);
        }
    }
}
