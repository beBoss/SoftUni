using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Company Phone: ");
        ulong companyPhone = ulong.Parse(Console.ReadLine());
        Console.Write("Company Fax: ");
        ulong companyFax = ulong.Parse(Console.ReadLine());
        Console.Write("Company Website: ");
        string companyWebsite = Console.ReadLine();
        Console.Write("Manager name: ");
        string managerName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        sbyte managerAge = sbyte.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        ulong managerPhone = ulong.Parse(Console.ReadLine());

        Console.WriteLine("Company name - {0} \r\nCompany address - {1} " +
                          "\r\nCompany phone - {2} \r\nCompany fax - {3} \r\nCompany website - {4}" +
                          "\r\nManager name - {5} \r\nManager last name - {6} \r\nManager age - {7} " +
                          "\r\nManager phone - {8}", companyName, companyAddress, companyPhone, companyFax,
            companyWebsite, managerName, managerLastName, managerAge, managerPhone);
    }
}