using System;

//Problem 12.	Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money
//(balance), bank name, IBAN, 3 credit card numbers associated with the account. 
//Declare the variables needed to keep the information for a single bank account using the appropriate 
//data types and descriptive names.

class BankAccountData
{
    static void Main()
    {
        string firstName = "Blagovest";
        string middleName = "Georgiev";
        string lastName = "Klisarski";
        decimal balance = 777777777m;
        string bankName = "Barclays";
        string iban = "AB 77 CDEF 0123 4567 8900 00";
        ulong creditCardOne = 9876543210123456;
        ulong creditCardTwo = 1234567890987654;
        ulong creditCardThree = 7951357862401233;

        Console.WriteLine("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}\r\n{5}\r\n{6}\r\n{7}\r\n{8}", 
            firstName, middleName, lastName, balance, bankName, iban, 
            creditCardOne, creditCardTwo, creditCardThree);
    }
}