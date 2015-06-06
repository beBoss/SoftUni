using System;

//Problem 15.	* Age after 10 Years
//old
//* Write a program to read your age from the console and print 
//how old you will be after 10 years.

//new
//Write a program to read your birthday from the console and print 
//how old you are now and how old you will be after 10 years.

class AgeAfterTenYears
{
    static void Main()
    {
        //old
        //Console.Write("Enter your age: ");
        //int age = int.Parse(Console.ReadLine());
        //Console.WriteLine("Your age after ten years will be {0}", age + 10);

        //new
        Console.Write("Enter your birth day (e.g. 1990.1.24): ");
        DateTime yourBirthDay = DateTime.Parse(Console.ReadLine());

        DateTime today = DateTime.Today;
        int age = today.Year - yourBirthDay.Year;

        Console.WriteLine("You are {0} years old.", age);
        Console.WriteLine("After 10 years you will be {0} years old.", age + 10);
    }
}