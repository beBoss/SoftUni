using System;

//Problem 5.	Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7. Examples:
//n	Third digit 7?
//5	false
//701	true
//9703	true
//877	false
//777877	false
//9999799	true

class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.Write("Enter a number with min 3 digits: ");
        int num = int.Parse(Console.ReadLine());


        if ( (num / 100) % 10 == 7)
        {
            Console.WriteLine("Third digit from Right to Left is 7");
        }
        else
        {
            Console.WriteLine("Third digit from Right to Left isn't 7");
        }

    }
}