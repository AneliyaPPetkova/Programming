using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Miss_Cat_2011
{
    class MissCat
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] cat = new int[11];
            int missCat = 0;
            int missCatVotes = 0;
            for (int i = 1; i <= n; i++)
            {
                byte catVotes = byte.Parse(Console.ReadLine());
                cat[catVotes]++;
            }
            for (int i = 1; i <= 10; i++)
			{
			    if (cat[i] >= missCatVotes)
                {
                    missCat = i;
                    missCatVotes = cat[i];
                }
			}
            Console.WriteLine(missCat);
        }
    }
}
