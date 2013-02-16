//Write a program that reads two arrays from the console and compares them element by element.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompareArrays
{
    class Compare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Size of the Arrays:");
            int size = int.Parse(Console.ReadLine());
            int[] arr1 = new int[size];
            int[] arr2 = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter elements with index {0} of both Arrays:", i);
                arr1[i] = int.Parse(Console.ReadLine());
                arr2[i] = int.Parse(Console.ReadLine());

                if (arr1[i] == arr2[i])
                {
                    Console.WriteLine("array1[{0}] = array2[{0}] = {1}",i , arr1[i]);
                }
                else if (arr1[i] > arr2[i])
                {
                    Console.WriteLine("array1[{0}] = {1} > array2[{0}] = {2}", i, arr1[i] , arr2[i]);
                }
                else if (arr1[i] < arr2[i])
                {
                    Console.WriteLine("array1[{0}] = {1} < array2[{0}] = {2}", i, arr1[i], arr2[i]);
                }
            }
        }
    }
}
