using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string k1 = Console.ReadLine();
            string k2 = Console.ReadLine();
            string k3 = Console.ReadLine();
            string k4 = Console.ReadLine();
            string k5 = Console.ReadLine();
            
            if (k1 == k2 && k2 == k3 && k3 == k4 && k4 == k5)
            {
                Console.WriteLine("Impossible");
            }
            else if (k1 == k2 && k2 == k3 && k3 == k4 || k1 == k3 && k3 == k4 && k4 == k5 || k1 == k2 && k2 == k4 && k4 == k5)
            {
                Console.WriteLine("Four of a Kind");
            }
            else if (((k1 == k2 && k2 == k3) && (k4 == k5)) || ((k1 == k3 && k3 == k4) && (k2 == k5)) || ((k1 == k2 && k2 == k4) && (k3 == k5)) || ((k4 == k5 && k5 == k1) && (k2 == k3)) || ((k4 == k3 && k3 == k2) && (k1 == k5)) || ((k1 == k4 && k4 == k3) && (k2 == k5)))
            {
                Console.WriteLine("Full House");
            }
            else if ((k1 == k2 && k2 == k3) || (k1 == k3 && k3 == k4) || (k1 == k2 && k2 == k4) || (k4 == k5 && k5 == k1) || (k4 == k3 && k3 == k2) || (k1 == k4 && k4 == k3))
            {
                Console.WriteLine("Three of a Kind");
            }
            else if ((k1 + k2 + k3 + k4 + k5) == "23456" || (k1 + k2 + k3 + k4 + k5) == "34567" || (k1 + k2 + k3 + k4 + k5) == "45678" || (k1 + k2 + k3 + k4 + k5) == "56789" || (k1 + k2 + k3 + k4 + k5) == "678910" || (k1 + k2 + k3 + k4 + k5) == "10JQKA" || (k1 + k2 + k3 + k4 + k5) == "JQKA2" || (k1 + k2 + k3 + k4 + k5) == "QKA23" || (k1 + k2 + k3 + k4 + k5) == "KA234" || (k1 + k2 + k3 + k4 + k5) == "A2345")
            {
                Console.WriteLine("Straight");
            }
            else if ((k1 == k2) || (k1 == k3) || (k1 == k4) || (k1 == k5) || (k2 == k3) || ( k2 == k4) || (k2 == k5) || (k3 == k4) || (k3 == k5) || (k4 == k5))
            {
                Console.WriteLine("One Pair");
            }
            else
            {
                Console.WriteLine("Nothing");
            }
        }
    }
}
