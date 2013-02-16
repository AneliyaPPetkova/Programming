using System;
using System.Collections.Generic;

class StringWithIntValues
{
    static void Main()
    {
        Console.WriteLine("Enter sequence of positive integers in one row, separated by spaces");
        string sequence = Console.ReadLine();
        string[] testsplit = sequence.Split(' ');
        List<int> positiveNum = new List<int>();
        int sum = 0;
        foreach (string s in testsplit)
        {
            positiveNum.Add(int.Parse(s));
        }
        for (int i = 0; i < positiveNum.Count; i++)
        {
            sum = sum + positiveNum[i];
        }
        Console.WriteLine(sum);
    }
}

