using System;

class SumThreeIntegers
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Result: {0} + {1} + {2} = {3}", a, b, c, a + b + c);
    }
}