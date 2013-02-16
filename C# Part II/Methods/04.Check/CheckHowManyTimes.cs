//Write a method that counts how many times given number appears in given array. 
//Write a test program to check if the method is working correctly.

using System;

class CheckHowManyTimes
{
    static int count = 0;
    static int Compare(double number, double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (number == array[i])
            {
                count++;
            }
        }
        return count;
    }
    static void Main()
    {
        int size;
        Console.WriteLine("Enter size of the array :");

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
                Console.Write("Invalid input. Enter integer number > 0: ");
            }
        }
        double[] arr = new double[size];

        //Initializing array:
        Console.WriteLine("Enter elements of the array:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter number:");
        double number = double.Parse(Console.ReadLine());

        //Check number:
        Console.WriteLine("Number {0} appears {1} times in the array.", number, Compare(number, arr));
    }
}
