using System;

class NullValues
{
    static void Main()
    {
        int? IntegerNumber=null;
        Console.WriteLine("Integer Variable with Null Value: {0}",IntegerNumber);
        IntegerNumber = 7;
        Console.WriteLine("Integer Variable with Value 7: {0}", IntegerNumber);
        double? DoubleNumber=null;
        Console.WriteLine("Double Variable with Null Value: {0}",DoubleNumber);
        DoubleNumber = 8.9;
        Console.WriteLine("Double Variable with Value 8,9: {0}", DoubleNumber);
    }
}

