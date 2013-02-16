//Write a method that calculates the number of workdays between today and given date, passed as parameter. 
//Consider that workdays are all days from Monday to Friday 
//except a fixed list of public holidays specified preliminary as array.

using System;

class NumberOfWorkdays
{
    static void Main()
    {
        DateTime today = DateTime.Now;
        DateTime end = new DateTime(1, 1, 1);
        try
        {
            end = DateTime.Parse(Console.ReadLine());
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Not valid date!"); ;
        }
        int nowYear = DateTime.Now.Year;
        DateTime[] holidays = 
                               {
                                   new DateTime(nowYear, 01, 01),
                                   new DateTime(nowYear, 01, 02),
                                   new DateTime(nowYear, 03, 03),
                                   new DateTime(nowYear, 05, 01),
                                   new DateTime(nowYear, 05, 06),
                                   new DateTime(nowYear, 05, 24),
                                   new DateTime(nowYear, 09, 06),
                                   new DateTime(nowYear, 09, 22),
                                   new DateTime(nowYear, 11, 01),
                                   new DateTime(nowYear, 12, 24),
                                   new DateTime(nowYear, 12, 25),
                                   new DateTime(nowYear, 12, 26),
                               };
        var totalDays = 0;
        for (var date = today; date < end; date = date.AddDays(1))
        {
            for (int i = 0; i < holidays.Length; i++)
            {
                if (date == holidays[i])
                {
                    continue;
                }
            }
            if (date.DayOfWeek != DayOfWeek.Saturday
                && date.DayOfWeek != DayOfWeek.Sunday)
            {
                totalDays++;
            }
        }
        Console.WriteLine(totalDays);
    }
}

