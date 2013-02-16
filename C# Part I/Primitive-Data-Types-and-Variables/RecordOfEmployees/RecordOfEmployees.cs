using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Your First Name, please:");
        string FirstName = Console.ReadLine();
        Console.Write("Enter Your Family Name, please:");
        string FamilyName = Console.ReadLine();
        Console.Write("Enter Your Age, please:");
        byte Age;
        while (true)
        {
            Age = byte.Parse(Console.ReadLine());
            if ((Age >= 1) && (Age <= 125))
            {
                break; 
            }
            else
            {
                Console.WriteLine("Invalid Value. Enter Your Age again, please:");
                continue;
            }                     
        }
        Console.Write("Enter Your Gender, please(m/f)");
        char AnswerGender;
        while (true)
        {
            string Gender = Console.ReadLine();
            AnswerGender = char.Parse(Gender);
            if ((AnswerGender == 'm') || (AnswerGender == 'f'))
            {
                break; 
            }
            else
            {
                Console.WriteLine("Invalid Gender. Please Enter Your Gender again:");
                continue;
            }
        }
        Console.Write("Enter Your ID Number, please:");
        ulong IDNumber;
        while (true)
        {
            IDNumber = ulong.Parse(Console.ReadLine());
            if ((IDNumber>=0) && (IDNumber<=9999999999))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Value. Please Enter Your ID Number again: ");
                continue;
            }
        }
        Console.Write("Enter Your Unique Employee Number,please: 2756");
        ushort EmployeeNumber;
        while (true)
	    {
            EmployeeNumber = ushort.Parse(Console.ReadLine());
            if ((EmployeeNumber>=0000)&&(EmployeeNumber<=9999))
            {
                break; 
            }
            else
            {
                Console.Write("Invalid Value. Please Enter Your Unique Employee Number again: 2756");
                continue;
            }
            
	    }
            Console.WriteLine();
      		Console.WriteLine("Your Personal Information is:");
            Console.WriteLine(new string('-',50));
            Console.Write("|First Name|".PadRight(20));
            Console.WriteLine("|Family Name|".PadRight(20));
            Console.Write(FirstName.PadRight(20));
            Console.WriteLine(FamilyName.PadRight(20));
            Console.WriteLine(new string('-', 50));
            Console.Write("|Age|".PadRight(10));
            Console.WriteLine("|Gender|".PadRight(10));
            Console.Write(Age.ToString().PadRight(10));
            Console.WriteLine(AnswerGender.ToString().PadRight(10));
            Console.WriteLine(new string('-', 50));
            Console.Write("|ID Number|".PadRight(15));
            Console.WriteLine("|Unique Employee Number|".PadRight(15));
            Console.Write(IDNumber.ToString().PadRight(15));
            Console.WriteLine("2756{0}", EmployeeNumber.ToString("D4"));
            Console.WriteLine(new string('-',50));                                
    }
}

