//Write a program that compares two char arrays lexicographically (letter by letter).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Lexico
{
    class Lexico
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Enter Size of the Arrays:");
            int size = int.Parse(Console.ReadLine());
            char[] arr1 = new char[size];
            char[] arr2 = new char[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter elements with index {0} of both Arrays:", i);
                arr1[i] = char.Parse(Console.ReadLine());
                arr2[i] = char.Parse(Console.ReadLine());

                if (arr1[i] == arr2[i])
                {
                    Console.WriteLine("array1[{0}] = array2[{0}] = {1}", i, arr1[i]);
                }
                else if (arr1[i] != arr2[i])
                {
                    Console.WriteLine("array1[{0}] = {1} ≠ array2[{0}] = {2}", i, arr1[i], arr2[i]);
                }

            }
        }
    }
}
