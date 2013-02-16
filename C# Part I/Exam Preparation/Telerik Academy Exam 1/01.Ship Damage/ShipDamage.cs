using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Ship_Damage
{
    class ShipDamage
    {
        static void Main(string[] args)
        {
            int sx1 = int.Parse(Console.ReadLine());
            int sy1 = int.Parse(Console.ReadLine());
            int sx2 = int.Parse(Console.ReadLine());
            int sy2 = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int cx1 = int.Parse(Console.ReadLine());
            int cy1 = int.Parse(Console.ReadLine());
            int cx2 = int.Parse(Console.ReadLine());
            int cy2 = int.Parse(Console.ReadLine());
            int cx3 = int.Parse(Console.ReadLine());
            int cy3 = int.Parse(Console.ReadLine());
            int distanceC1 = 2*h - cy1;
            int distanceC2 = 2*h - cy2;
            int distanceC3 = 2*h - cy3;
            int damageC1 = 0;
            int damageC2 = 0;
            int damageC3 = 0;
            int minSx = Math.Min(sx1,sx2);
            int maxSx = Math.Max(sx1,sx2);
            int minSy = Math.Min(sy1,sy2);
            int maxSy = Math.Max(sy1,sy2);
            if ((cx1 > minSx && cx1 < maxSx) && (distanceC1 > minSy && distanceC1 < maxSy))
            {
                damageC1 = 100;
            }
            if ((cx2 > minSx && cx2 < maxSx) && (distanceC2 > minSy && distanceC2 < maxSy))
            {
                damageC2 = 100;
            }
            if ((cx3 > minSx && cx3 < maxSx) && (distanceC3 > minSy && distanceC3 < maxSy))
            {
                damageC3 = 100;
            }
            if (((cx1 > minSx && cx1 < maxSx) && ((distanceC1) == minSy || (distanceC1) == maxSy)) || ((cx1 == minSx || cx1 == maxSx) && ((distanceC1) > minSy && (distanceC1) < maxSy)))
            {
                damageC1 = 50;
            }
            if (((cx2 > minSx && cx2 < maxSx) && ((distanceC2) == minSy || (distanceC2) == maxSy)) || ((cx2 == minSx || cx2 == maxSx) && ((distanceC2) > minSy && (distanceC2) < maxSy)))
            {
                damageC2 = 50;
            }
            if (((cx3 > minSx && cx3 < maxSx) && ((distanceC3) == minSy || (distanceC3) == maxSy)) || ((cx3 == minSx || cx3 == maxSx) && ((distanceC3) > minSy && (distanceC3) < maxSy)))
            {
                damageC3 = 50;
            }
            if ((cx1 == minSx || cx1 == maxSx) && ((distanceC1) == minSy || (distanceC1) == maxSy))
            {
                damageC1 = 25;
            }
            if ((cx2 == minSx || cx2 == maxSx) && ((distanceC2) == minSy || (distanceC2) == maxSy))
            {
                damageC2 = 25;
            }
            if ((cx3 == minSx || cx3 == maxSx) && ((distanceC3) == minSy || (distanceC3) == maxSy))
            {
                damageC3 = 25;
            }
            
            int damage = damageC1 + damageC2 + damageC3;
            Console.WriteLine(damage + "%"); 
        }
    }
}
