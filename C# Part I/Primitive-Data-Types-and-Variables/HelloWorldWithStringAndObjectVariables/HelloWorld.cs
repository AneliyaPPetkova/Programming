using System;

class Program
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object fullString = hello + " " + world;
        string helloWorld = fullString + "!";
        Console.WriteLine(helloWorld);
    }
}

