//We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.

using System;
using System.Linq;
class Program
{
    static void Main()
    {
        Console.Title = "Check if the Sum of some Subset of Given 5 Integer Numbers is 0";
        int[] ArrayWith5Numbers = new int[5];
        string[] ArrayString = new string[5];
        int sum = 0;
        for (int i = 0; i < 5; i++)
        {
            while (true)
            {
                Console.Write("Enter Integer Number: ");
                ArrayString[i] = Console.ReadLine();
                if (int.TryParse(ArrayString[i], out ArrayWith5Numbers[i]))
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid input. Enter Integer Number: ");
                }
            }
        }
        for (int i = 0; i < ArrayWith5Numbers.Length; i++)
        {
           sum += ArrayWith5Numbers[i]; 
           for (int j = i + 1; j < ArrayWith5Numbers.Length; j++)
           {
               if (ArrayWith5Numbers[i] + ArrayWith5Numbers[j] == 0)
               {
                   Console.WriteLine("{0} + {1} = 0", ArrayWith5Numbers[i], ArrayWith5Numbers[j]);
               }
               for (int k = j + 1; k < ArrayWith5Numbers.Length; k++)
               {
                   if (ArrayWith5Numbers[i] + ArrayWith5Numbers[j] + ArrayWith5Numbers[k] == 0)
                   {
                       Console.WriteLine("{0} + {1} + {2} = 0", ArrayWith5Numbers[i], ArrayWith5Numbers[j], ArrayWith5Numbers[k]);
                   }
                   for (int n = k + 1; n < ArrayWith5Numbers.Length; n++)
                   {
                       if (ArrayWith5Numbers[i] + ArrayWith5Numbers[j] + ArrayWith5Numbers[k] + ArrayWith5Numbers[n] == 0)
                       {
                           Console.WriteLine("{0} + {1} + {2} + {3} = 0", ArrayWith5Numbers[i], ArrayWith5Numbers[j], ArrayWith5Numbers[k], ArrayWith5Numbers[n]);
                       }
                   }
               }
           }
        }
        if (sum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", ArrayWith5Numbers[0], ArrayWith5Numbers[1], ArrayWith5Numbers[2], ArrayWith5Numbers[3], ArrayWith5Numbers[4]);
        }
    }
}

