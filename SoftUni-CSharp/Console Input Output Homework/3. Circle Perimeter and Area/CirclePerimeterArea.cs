using System;

class CirclePerimeterArea
{
    static void Main()
    {
        Console.Write("Enter the radius: ");
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter: {0:f2}, Area: {1:f2}", 2 * Math.PI * r, Math.PI * r * r);
    }
}