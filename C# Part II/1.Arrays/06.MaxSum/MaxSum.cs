//Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSum
{
    class MaxSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first integer number N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer number K:");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an Array of {0} elements:",n);
            double[] arr = new double[n];
            int index = 0;
            double maxSum1 = 0;
            double maxSum2 = 0;
            double sum2 = 0;
            double replace;
            for (int i = 0; i < n; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }
            //consecutive k elements:
            Console.WriteLine("For consecutive k elements:");
            Console.WriteLine();
            for (int j = 0; j < n - k; j++)
            {
                for (int i = 0; i < k; i++)
                {
                    sum2 = sum2 + arr[j + i];
                    if (sum2 > maxSum2)
                    {
                        maxSum2 = sum2;
                        index = j;
                    }
                }
                sum2 = 0;
            }
            Console.WriteLine("Those consecutive {0} Elements, that have maximal sum are:", k);
            for (int i = index; i < index + k; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("The Sum is {0}.", maxSum2);
            Console.WriteLine();
            //non-consecutive k elements:
            Console.WriteLine("For non-consecutive k elements:");
            Console.WriteLine();
            for (int j = 0; j < n; j++)
            {
                for (int i = j+1; i < n; i++)
                {
                    if (arr[i] > arr[j])
                    {
                        replace = arr[j];
                        arr[j] = arr[i];
                        arr[i] = replace;
                    }

                }
            }

            Console.WriteLine("Those non-consecutive {0} Elements, that have maximal sum are:",k);
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(arr[i]);
                maxSum1 = maxSum1 + arr[i];
            }
            Console.WriteLine("The Sum is {0}.",maxSum1);
            
        }
    }
}
