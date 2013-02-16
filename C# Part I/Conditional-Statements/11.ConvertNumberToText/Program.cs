//* Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
//0  "Zero"
//273  "Two hundred seventy three"
//400  "Four hundred"
//501  "Five hundred and one"
//711  "Severn hundred and eleven"

using System;

class Program
{
    static void Main()
    {
        int Number;
        int Remainder;
        Console.Write("Enter Integer Number in the Range [0..999]: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out Number) && (Number >= 0) && (Number <= 999))
            {
                break;
            }
            else
            {
                Console.Write("Enter Integer Number in the Range [0..999]: ");
            }
        }
        Console.Write("\n{0} -> ",Number);
        if (Number == 0)
        {
            Console.Write("Zero");
        }
        if (Number >= 100 && Number <= 999)
            {
                switch (Number / 100)
                {
                    case 1:
                        Console.Write(" One Hundred");
                        break;
                    case 2:
                        Console.Write(" Two Hundred");
                        break;
                    case 3:
                        Console.Write(" Three Hundred");
                        break;
                    case 4:
                        Console.Write(" Four Hundred");
                        break;
                    case 5:
                        Console.Write(" Five Hundred");
                        break;
                    case 6:
                        Console.Write(" Six Hundred");
                        break;
                    case 7:
                        Console.Write(" Seven Hundred");
                        break;
                    case 8:
                        Console.Write(" Eight Hundred");
                        break;
                    case 9:
                        Console.Write(" Nine Hundred");
                        break; 
                    default:
                        break;
                }
                if (Number % 100 != 0)
                {
                    Console.Write(" and");
                    Remainder = Number % 100;
                    Number = Remainder;
                }  
            }
        switch (Number)
        {
            case 10:
                Console.Write(" Ten");
                break;
            case 11:
                Console.Write(" Eleven");
                break;
            case 12:
                Console.Write(" Twelve");
                break;
            case 13:
                Console.Write(" Thirteen");
                break;
            case 14:
                Console.Write(" Fourteen");
                break;
            case 15:
                Console.Write(" Fifteen");
                break;
            default:
                break;
        }
        switch (Number / 10)
	    {
            case 2: 
                Console.Write(" Twenty");
                break;
            case 3:
                Console.Write(" Thirty");
                break;
            case 4:
                Console.Write(" Forty");
                break;
            case 5:
                Console.Write(" Fifty");
                break;
            case 6:
                Console.Write(" Sixty");
                break;
            case 7:
                Console.Write(" Seventy");
                break;
            case 8:
                Console.Write(" Eighty");
                break;
            case 9:
                Console.Write(" Ninety");
                break;     
	    }
        if ((Number >= 0 && Number <= 9) || ((Number >= 16 && Number <= 99)))
        {
            switch ((Number % 10))
            {
                case 1:
                    Console.Write(" One");
                    break;
                case 2:
                    Console.Write(" Two");
                    break;
                case 3:
                    Console.Write(" Three");
                    break;
                case 4:
                    Console.Write(" Four");
                    break;
                case 5:
                    Console.Write(" Five");
                    break;
                case 6:
                    Console.Write(" Six");
                    if (Number == 16)
                    {
                        Console.Write("teen   ");
                    }
                    break;
                case 7:
                    Console.Write(" Seven");
                    if (Number == 17)
                    {
                        Console.Write("teen   ");
                    }
                    break;
                case 8:
                    Console.Write(" Eight");
                    if (Number == 18)
                    {
                        Console.Write("teen   ");
                    }
                    break;
                case 9:
                    Console.Write(" Nine");
                    if (Number == 19)
                    {
                        Console.Write("teen   ");
                    }
                    break;
                default:
                    break;
            }
            
        }
        Console.WriteLine(); 
    }
    
}

