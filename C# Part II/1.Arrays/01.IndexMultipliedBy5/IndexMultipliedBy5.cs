//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
//Print the obtained array on the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.IndexMultipliedBy5
{
    class IndexMultipliedBy5
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            for (int i = 0; i < 20; i++)
            {
                arr[i] = i * 5;
                Console.WriteLine(arr[i]);
            }
        }
    }
}
