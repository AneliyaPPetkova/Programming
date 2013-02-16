//A company has name, address, phone number, fax number, web site and manager. The manager has first name,
//last name, age and a phone number. Write a program that reads the information about a company and its manager
//and prints them on the console.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the Name of the Company, please: ");
        string CompanyName = Console.ReadLine();
        Console.Write("Enter the Address of the Company, please: ");
        string CompanyAddress = Console.ReadLine();
        Console.Write("Enter Company Phone Number, please: ");
        string CompanyPhoneNumber = Console.ReadLine();
        Console.Write("Enter Company FAX Number, please: ");
        string CompanyFaxNumber = Console.ReadLine();
        Console.Write("Enter Company Web site, please: ");
        string CompanyWebSite = Console.ReadLine();
        Console.Write("Enter First Name of the {0} Manager, please: ",CompanyName);
        string ManagerFirstName = Console.ReadLine();
        Console.Write("Enter Last Name of the {0} Manager, please: ",CompanyName);
        string ManagerLastName = Console.ReadLine();
        Console.Write("Enter Age of the {0} Manager, please: ",CompanyName);
        int ManagerAge;
        while (true)
        {
            ManagerAge = int.Parse(Console.ReadLine());
            if (ManagerAge>18)
            {
                break;   
            }
            else
            {
                Console.Write("Invalid input. Enter Age again: ");
                continue;
            }
        }
        Console.Write("Enter Manager Phone Number: ");
        string ManagerPhoneNumber = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine(new string('-', 70));
        Console.WriteLine("Information about the Company:");
        Console.WriteLine(new string('-', 70));
        Console.Write("|Company Name|".PadRight(30));
        Console.WriteLine("{0,30}",CompanyName);
        Console.Write("|Company Address|".PadRight(30));
        Console.WriteLine("{0,30}",CompanyAddress);
        Console.Write("|Company Phone Number|".PadRight(30));
        Console.WriteLine("{0,30}",CompanyPhoneNumber);
        Console.Write("|Company Fax Number|".PadRight(30));
        Console.WriteLine("{0,30}",CompanyFaxNumber);
        Console.Write("|Company Web Site|".PadRight(30));
        Console.WriteLine("{0,30}",CompanyWebSite);
        Console.WriteLine(new string('-', 70));
        Console.WriteLine("Information about the Company Manager:");
        Console.WriteLine(new string('-', 70));
        Console.Write("|First Name|".PadRight(30));
        Console.WriteLine("{0,30}",ManagerFirstName);
        Console.Write("|Last Name|".PadRight(30));
        Console.WriteLine("{0,30}",ManagerLastName);
        Console.Write("|Age|".PadRight(30));
        Console.WriteLine("{0,30}",ManagerAge);
        Console.Write("|Phone Number|".PadRight(30));
        Console.WriteLine("{0,30}",ManagerPhoneNumber);
        Console.WriteLine(new string('-', 70));
    }
}

