using System;

//Problem 13.	Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable. 
//Try to print these variables at the console. Try to add some number or the null literal 
//to these variables and print the result.

class NullValuesArithmetic
{
    static void Main()
    {
        int? valueOne = null;
        double? valueTwo = null;

        Console.WriteLine("{0}{1}", valueOne, valueTwo);

        valueOne = 7;
        valueTwo = 7.7777777;

        Console.WriteLine("{0}, {1}", valueOne, valueTwo);
    }
}