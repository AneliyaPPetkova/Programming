using System;

class BankAccount
{
    static void Main()
    {
        Console.Write("Enter Your First Name, please:");
        string FirstName = Console.ReadLine();
        Console.Write("Enter Your Middle Name, please:");
        string MiddleName = Console.ReadLine();
        Console.Write("Enter Your Last Name, please:");
        string LastName = Console.ReadLine();
        string FullName = FirstName + " " + MiddleName + " " + LastName;
        decimal Balance = 123456;
        Console.Write("Enter Your Bank Name, please:");
        string BankName = Console.ReadLine();
        Console.Write("Enter Your IBAN, please:");
        string IBAN = Console.ReadLine();
        Console.Write("Enter Your BIC code, please:");
        string BICcode = Console.ReadLine();
        Console.Write("Enter Your First Credit Card Number:");
        string FirstCreditCard = Console.ReadLine();
        Console.Write("Enter Your Second Credit Card Number:");
        string SecondCreditCard = Console.ReadLine();
        Console.Write("Enter Your Third Credit Card Number:");
        string ThirdCreditCard = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Your Personal Information is:");
        Console.WriteLine(new string('-', 60));
        Console.WriteLine("|Full Name|".PadRight(50));
        Console.WriteLine(FullName.PadRight(20));
        Console.WriteLine(new string('-', 60));
        Console.Write("|Balance|".PadRight(15));
        Console.WriteLine("|Bank Name|".PadRight(10));
        Console.Write(Balance.ToString().PadRight(15));
        Console.WriteLine(BankName.ToString().PadRight(10));
        Console.WriteLine(new string('-', 60));
        Console.Write("|IBAN|".PadRight(20));
        Console.WriteLine("|BIC code|".PadRight(10));
        Console.Write(IBAN.ToString().PadRight(20));
        Console.WriteLine(BICcode.ToString().PadRight(10));
        Console.WriteLine(new string('-', 60));
        Console.Write("|First Credit Card Number|".PadRight(30));
        Console.WriteLine("|Second Credit Card Number|".PadRight(25));
        Console.Write(FirstCreditCard.ToString().PadRight(30));
        Console.WriteLine(SecondCreditCard.ToString().PadRight(25));
        Console.WriteLine(new string('-', 60));
        Console.WriteLine("|Third Credit Card Number|".PadRight(25));
        Console.Write(ThirdCreditCard.ToString().PadRight(25));
    }
}

