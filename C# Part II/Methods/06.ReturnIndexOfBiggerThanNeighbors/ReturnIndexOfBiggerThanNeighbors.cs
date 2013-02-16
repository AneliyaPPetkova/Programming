//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;

class ReturnIndexOfBiggerThanNeighbors
{
    static int position;
    static int IsBigger(int[] array)
    {
        for (int i = 1; i < array.Length - 1; i++)
        {
            if ((array[i] > array[i - 1]) && (array[i] > array[i + 1]))
            {
                return position = i;
            }
        }
        return -1;
    }
    static void Main()
    {
        int size;
        Console.WriteLine("Enter size of the array:");

        //Check size:
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out size) && (size > 0))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter integer number for size > 0: ");
            }
        }
        int[] arr = new int[size];

        //Initializing array:
        Console.WriteLine("Enter elements of the array:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        //Return the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element:
        Console.WriteLine("Index = {0}", IsBigger(arr));
    }
}

