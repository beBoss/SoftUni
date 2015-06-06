using System;

class BiggestThreeNumbers
{
    static void Main(string[] args)
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        bool aGreaterThenB = a > b;
        bool bGreaterThenC = b > c;

        if (aGreaterThenB && (bGreaterThenC || b == c))
        {
            Console.WriteLine(a);
        }
        else if (!aGreaterThenB && bGreaterThenC)
        {
            Console.WriteLine(b);
        }
        else if (!bGreaterThenC && (!aGreaterThenB || a == b) || aGreaterThenB)
        {
            Console.WriteLine(c);
        }
    }
}