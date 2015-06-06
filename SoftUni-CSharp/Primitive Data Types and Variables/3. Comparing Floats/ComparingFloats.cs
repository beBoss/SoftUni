using System;

//Problem 3.	Comparing Floats

//Write a program that safely compares floating-point numbers with precision 
//eps = 0.000001. Note that we cannot directly compare two floating-point 
//numbers a and b by a==b because of the nature of the floating-point arithmetic. 
//Therefore, we assume two numbers are equal if they are more closely to each other 
//than a fixed constant eps. Examples:
//  5.3	        6.01	    false	The difference of 0.71 is too big (> eps)
//  5.00000001	5.00000003	true	The difference 0.00000002 < eps
//  -0.0000007	0.00000007	true	The difference 0.00000077 < eps
//  -4.999999	-4.999998	false	Border case. The difference 0.000001 == eps. 
//                                  We consider the numbers are different.


class ComparingFloats
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        float precision = 0.000001f;

        bool areEqual = (Math.Abs(firstNumber - secondNumber) < precision);
        Console.WriteLine(areEqual);
    }
}

