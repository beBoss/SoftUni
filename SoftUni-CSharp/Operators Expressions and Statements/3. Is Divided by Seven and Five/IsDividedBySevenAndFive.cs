using System;

//Problem 3.	Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided 
//(without remainder) by 7 and 5 in the same time. Examples:
//n	Divided by 7 and 5?
//3	false
//0	false
//5	false
//7	false
//35	true
//140	true

class IsDividedBySevenAndFive
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (( num % 5 == 0) & (num % 7 == 0))
        {
            Console.WriteLine("{0} can be divided by 7 and 5 in the same time", num);
        }
        else
        {
            Console.WriteLine("{0} can't be divided by 7 and 5 in the same time.", num);
        }
    }
}