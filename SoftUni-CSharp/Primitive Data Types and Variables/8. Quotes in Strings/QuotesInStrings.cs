using System;

//Problem 8.	Quotes in Strings

//Declare two string variables and assign them with following value:
//The "use" of quotations causes difficulties.
//Do the above in two different ways: with and without using quoted strings. 
//Print the variables to ensure that their value was correctly defined.

class QuotesInStrings
{
    static void Main()
    {
        string varOne = @"The ""use"" of quotations causes difficulties.";
        string varTwo = "The \"use\" of quotations causes difficulties.";

        Console.WriteLine("{0}\r\n{1}", varOne, varTwo);
    }
}