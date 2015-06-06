using System;

//Problem 4.	Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height. Examples:
//width	height	perimeter area
//3	4	14	12
//2.5	3	11	7.5
//5	5	20	25

class RectanglePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter a rectangle's width: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Enter a rectangle's height: ");
        double height = double.Parse(Console.ReadLine());

        double area = width * height;
        double perimeter = 2 * (width + height);
        Console.WriteLine("The rectangle's perimeter is {0} and area is {1}", perimeter, area);
    }
}