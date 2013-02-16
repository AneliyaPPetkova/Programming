//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:
//	N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;

class Comb
{
    static int N;                             
    static int K;                       
    static int[] ArrayOfInts;          

    static int ReadInts(string Value)   
    {
        while (true)
        {
            int Integer;
            bool Result = int.TryParse(Value, out Integer);
            if (Result == true)
            {
                return Integer;
            }
            else
            {
                Console.Write(@"""{0}"" is not an integer. Try again: ", Value);
                Value = Console.ReadLine();
            }
        }
    }
    static void Combinations(int Combination = 0) 
    {
        if (Combination == K)
        {
            PrintCombinations();
            return;
        }
        for (int counter = 1; counter <= N; counter++)
        {
            ArrayOfInts[Combination] = counter;
            Combinations(Combination + 1);
        }
    }

    static void PrintCombinations()          
    {
        for (int index = 0; index < K; index++)
        {
            for (int check = index + 1; check < K; check++)
            {
                if (ArrayOfInts[index] == ArrayOfInts[check])
                {
                    return;
                }
                else
                {
                    Console.Write("{");
                }
            }
            if (index < (K - 1))
            {
                Console.Write("{0}, ", ArrayOfInts[index]);
            }
            else
            {
                Console.Write("{0}", ArrayOfInts[index]);
            }
        }
        Console.WriteLine("}");
    }

    static void Main(string[] args)
    {
        Console.Write("Input number of elements: ");
        N = ReadInts(Console.ReadLine());
        K = 0;
        while (K > N || K < 1)
        {
            Console.Write("Input size of variations(should be less than number of elements): ");
            K = ReadInts(Console.ReadLine());
        }
        ArrayOfInts = new int[N];
        Combinations();
    }
}

