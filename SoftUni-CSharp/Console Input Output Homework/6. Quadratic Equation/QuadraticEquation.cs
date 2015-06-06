using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = "); 
        double c = double.Parse(Console.ReadLine());

        double discriminant = ((b * b) - (4 * a * c));

        if (discriminant > 0)
        {
            double x1, x2;
            x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("x1 = {0} x2 = {1}", x1, x2);
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("There are no real roots");
        }
        else if (discriminant == 0)
        {
            Console.WriteLine("x1 = x2 = {0}", -b / (2 * a));
        }
    }
}