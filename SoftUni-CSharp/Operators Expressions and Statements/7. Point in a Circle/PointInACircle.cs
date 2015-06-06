using System;

//Problem 7.	Point in a Circle

//Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). Examples:
//x	y	inside	 
//0	1	true	
//-2	0	true	
//-1	2	false	
//1.5	-1	true	
//-1.5	-1.5	false	
//100	-30	false	
//0	0	true	
//0.2	-0.8	true	
//0.9	-1.93	false	
//1	1.655	true	

class PointInACircle
{
    static void Main()
    {
        Console.Write("X = ");
        double xCord = double.Parse(Console.ReadLine());
        Console.Write("Y = ");
        double yCord = double.Parse(Console.ReadLine());
        
        double radios = 2;

        bool isInTheCircle = (xCord * xCord) + (yCord * yCord) <= radios * radios;
        Console.WriteLine("Is the point in the circle: {0}", isInTheCircle ? "true" : "false");
    }
}