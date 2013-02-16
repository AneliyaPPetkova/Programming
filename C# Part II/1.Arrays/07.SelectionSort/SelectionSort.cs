//Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. Use the "selection sort" algorithm: 
//Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size of array N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an Array of {0} elements:", n);
            double[] arr = new double[n];
            double replace;
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
        }
    }
}
