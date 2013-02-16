using System;

class Exchange
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int exchange;
        Console.Write("{0}  {1}\n", a, b);
        exchange = b;
        b = a;
        a = exchange;
        Console.Write("{0}  {1}\n", a, b);
    }
}

