using System;

class MembersOfTheSequence
{
    static void Main()
    {
        for (int i = 2; i <=10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);  
            }
            else
            {
                Console.WriteLine(-i);
            }
        }
    }
}
