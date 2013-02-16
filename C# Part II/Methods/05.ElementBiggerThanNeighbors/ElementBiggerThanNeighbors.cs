//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

using System;

class ElementBiggerThanNeighbors
{
    static void IsBigger(int position, int[] array)
    {
        if ((position == 0) || (position == array.Length - 1))
        {
            Console.WriteLine("The Element doesn't have two neighbors.");
        }
        else if ((array[position] > array[position - 1]) && (array[position] > array[position + 1]))
        {
            Console.WriteLine("The Element at {0} position is bigger than its two neighbors.", position);
        }
        else
        {
            Console.WriteLine("The Element at {0} position is not bigger than its two neighbors.", position);
        }
    }
    static void Main()
    {
        int size;
        int position;
        Console.WriteLine("Enter size of the array and position of element:");

        //Check size and position:
        while (true)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            if (int.TryParse(input1, out size) && int.TryParse(input2, out position) && (size > 0) && (position >= 0))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter integer number for size > 0 and for position >= 0: ");
            }
        }
        int[] arr = new int[size];

        //Initializing array:
        Console.WriteLine("Enter elements of the array:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        //Check number at exact position:
        IsBigger(position, arr);
    }
}

