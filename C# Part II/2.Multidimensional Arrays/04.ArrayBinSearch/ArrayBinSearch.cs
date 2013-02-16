//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;

class ArrayBinSearch
{
    static void Main(string[] args)
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        Console.Write("Target: ");
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[size];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Array[{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);

        int target = k;
        int index = -1;

        while (index < 0)
        {
            index = Array.BinarySearch(arr, target);
            target--;
        }

        Console.Write("The biggest number <= K is: {0}.", arr[index]);
        Console.WriteLine();
    }
}

