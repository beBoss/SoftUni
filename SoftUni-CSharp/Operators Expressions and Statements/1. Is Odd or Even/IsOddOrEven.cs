using System;

//Problem 1.	Odd or Even Integers
//Write an expression that checks if given integer is odd or even. Examples:
//n	Odd?
//3	true
//2	false
//-2	false
//-1	true
//0	false


class IsOddOrEven
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("{0} is even.", num);
        }
        else
        {
            Console.WriteLine("{0} is odd.", num);
        }
    }
}