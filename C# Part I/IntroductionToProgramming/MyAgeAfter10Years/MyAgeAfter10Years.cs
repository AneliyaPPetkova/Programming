using System;

class MyAgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Enter Your Age Now:");
        byte age;
        while (true)
        {
            age = byte.Parse(Console.ReadLine());
            if (age <= 120)
            {
                DateTime afterTenYears = DateTime.Now.AddYears(10);
                Console.WriteLine("In {0} year you will be {1} years old", afterTenYears.Year, age + 10);
                break;
            }
            else
            {
                Console.WriteLine("Invalid value. Enter Your Age Now again:");
            }
        }
    }
}
