using System;

class Program
{
    static void Main()
    {
        string withQuotation = "The \"use\" of quatations causes difficulties";
        string withoutQuatation = @"The ""use"" of quatations causes difficulties";
        Console.WriteLine(withQuotation);
        Console.WriteLine(withoutQuatation);
    }
}
