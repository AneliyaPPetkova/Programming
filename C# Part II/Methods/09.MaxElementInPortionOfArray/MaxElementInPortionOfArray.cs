//Write a method that return the maximal element in a portion of array of integers starting at given index. 
//Using it write another method that sorts an array in ascending / descending order.

using System;

class MaxElementInPortionOfArray
{

    static void SortPortion(int[] array)
    {
        int temp;
        for (int j = 0; j < array.Length; j++)
        {
            for (int i = j + 1; i < array.Length; i++)
            {
                if ((array[j] < array[i]))
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }            
        }
        Print(array);
    }
    static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
    static void MaxElement(int[] array)
    {
        Console.WriteLine(array[0]);
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
        int startPosition;
        Console.WriteLine("Enter starting position:");

        //Check position:
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out startPosition) && (startPosition >= 0) && (startPosition < arr.Length))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter integer number for position >= 0 and < {0}: ", size);
            }
        }

        //Initializing portion array:
        int length = arr.Length - startPosition;
        int[] portionArray = new int[length];
        for (int j = 0; j < length; j++)
        {
            portionArray[j] = arr[startPosition + j];
        }

        Console.WriteLine();
        Console.WriteLine("The portion of array of integers starting at {0} index:",startPosition);
        Print(portionArray);
        Console.WriteLine();
        Console.WriteLine("Sorted portion of the array:");
        SortPortion(portionArray);
        Console.WriteLine();
        Console.WriteLine("The maximal element in a portion of array is:");
        MaxElement(portionArray);
    }
}

