using System;

//Problem 10.	Exchange Variable Values

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values. 
//Print the variable values before and after the exchange.

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("a = {0}, b = {1}", a, b);

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("a = {0}, b = {1}", a, b);
    }
}