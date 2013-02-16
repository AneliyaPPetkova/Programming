using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Math_Expression
{
    class MathExpression
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal m = decimal.Parse(Console.ReadLine());
            decimal p = decimal.Parse(Console.ReadLine());
            decimal someNumber = 128.523123123M;
            int rem = ((int)(m % 180));
            
            decimal mathExpession = (decimal)(((n * n + 1 / (m * p) + 1337) / (n - someNumber * p)) + (decimal)(Math.Sin(rem)));
            Console.WriteLine("{0:0.000000}", mathExpession);
        }
    }
}
