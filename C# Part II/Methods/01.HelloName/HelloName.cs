//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
//Write a program to test this method.

using System;

class HelloName
{
    static void PrintName()
    {
        Console.WriteLine("What's your name?");
        string firstName = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", firstName);
    }
    static void Main()
    {
        PrintName();
    }
}

