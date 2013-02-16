//Write a program that applies bonus scores to given scores in the range [1..9]. 
//The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10;
//if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000. 
//If it is zero or if the value is not a digit, the program must report an error.
//Use a switch statement and at the end print the calculated new value in the console.

using System;

class Program
{
    static void Main()
    {
        int Scores;
        int BonusScores;
        Console.Write("Enter Your Score in the Range [1..9]: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out Scores) && (Scores >= 1) && (Scores <= 9))
            {
                break;
            }
            else
            {
                Console.Write("Error! Enter Your Score in the Range [1..9]: ");
            }
        }
        Console.WriteLine();
        Console.Write("Your Score is {0} -> ", Scores);
        switch (Scores)
        {
            case 1:
            case 2:
            case 3:
                BonusScores = Scores*10;
                Console.WriteLine("Your Bonus Score is {0} ", BonusScores);
                break;
            case 4:
            case 5:
            case 6:
                BonusScores = Scores * 100;
                Console.WriteLine("Your Bonus Score is {0} ", BonusScores);
                break;
            case 7:
            case 8:
            case 9:
                BonusScores = Scores * 1000;
                Console.WriteLine("Your Bonus Score is {0} ",BonusScores);
                break;
        }
    }
}

