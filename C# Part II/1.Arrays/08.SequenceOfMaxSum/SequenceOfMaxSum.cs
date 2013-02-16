//Write a program that finds the sequence of maximal sum in given array. Example:
//	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//	Can you do it with only one loop (with single scan through the elements of the array)?

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SequenceOfMaxSum
{
    class SequenceOfMaxSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size of array N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an Array of {0} elements:", n);
            double[] arr = new double[n];
            int index = 0;
            double maxSum = 0;
            double sum = 0;
            double numOfElements = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }
            for (int k = 0; k < n; k++)
            {
                for (int j = 0; j < n - k; j++)
                {
                    for (int i = 0; i < k; i++)
                    {
                        sum = sum + arr[j + i];
                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            index = j;
                            numOfElements = k;
                        }
                    }
                    sum = 0;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Those Elements, that have maximal sum are:");
            for (int i = index; i < index + numOfElements; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("The Sum is {0}.", maxSum);
            Console.WriteLine();
        }
    }
}
