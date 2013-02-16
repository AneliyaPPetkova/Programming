//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

using System;
using System.Text;

class CheckBrackets
{
    static bool Check(string expression)
    {
        bool correct = false;
        int count = 0;
        foreach (var ch in expression)
        {
            if (ch == '(')
            {
                count++;
            }
            else if (ch == ')')
            {
                count--;
            }
            if (count < 0)
            {
                correct = false;
                return correct;
            }
        }
        if (count == 0)
        {
            correct = true;
        }
        return correct;
    }
    static void Main()
    {
        Console.WriteLine("Enter expression:");
        string expression = Console.ReadLine();
        bool correct = Check(expression);
        if (correct == true)
        {
            Console.WriteLine("The expression is correct!");
        }
        else
        {
            Console.WriteLine("The expression is not correct!");
        }
    }
}

