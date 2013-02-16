//Write a program that finds the most frequent number in an array. Example:
//	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size of array N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an Array of {0} elements:", n);
            double[] arr = new double[n];
            double replace;
            int tempcount = 1;
            int count = 1;
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }
            for (int j = 0; j < n; j++)
            {
                for (int i = j + 1; i < n; i++)
                {
                    if (arr[j] > arr[i])
                    {
                        replace = arr[i];
                        arr[i] = arr[j];
                        arr[j] = replace;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Sorted Array:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            for (int i = 1; i < n; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    ++tempcount;
                    if (tempcount > count)
                    {
                        count = tempcount;
                        index = i;
                    }
                }
                else
                {
                    tempcount = 1;
                }
            }
            Console.WriteLine("Most frequent number in an array is: {0} -> {1} times",arr[index] , count);
        }
    }
}
