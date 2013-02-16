//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaximalSequence
{
    class Increase
    {
        static void Main(string[] args)
        {
            int count = 1;
            int tempcount = 1;
            int index = 0;
            Console.WriteLine("Enter Size of the Array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < size; i++)
            {
                if (arr[i] == arr[i - 1]+1)
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
            for (int i = count - 1; i >= 0; i--)
            {
                Console.Write(arr[index - i] + " ");
            }
            Console.WriteLine();
        }
    }
}
