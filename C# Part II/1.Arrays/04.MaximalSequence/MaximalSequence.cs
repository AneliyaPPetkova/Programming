//Write a program that finds the maximal sequence of equal elements in an array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaximalSequence
{
    class MaximalSequence
    {
        static void Main(string[] args)
        {
            int count = 1;
            int tempcount = 1;
            int index = 0;
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < size; i++)
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
            for (int i = 0; i < count; i++)
            {
                Console.Write(arr[index] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(index);
        }
    }
}
