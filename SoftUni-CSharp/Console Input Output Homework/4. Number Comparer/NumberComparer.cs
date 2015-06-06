using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double firstNum = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double secondNum = double.Parse(Console.ReadLine());

        double result = Math.Max(firstNum, secondNum);
        Console.WriteLine("The bigger number is: {0}", result);
    }
}