using System;

//Problem 10.	Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
//and out of the rectangle R(top=1, left=-1, width=6, height=2). Examples:
//x	    y	    inside K & outside of R	 
//1	    2	    yes	
//2.5	2	    no	
//0	    1	    no	
//2.5	1   	no	
//2	    0	    no	
//4	    0	    no	
//2.5	1.5	    no	
//1	    2.5	    yes	
//-100	-100	no	

class PointInOutOfCircleAndRectangle
{
    static void Main()
    {
        Console.Write("X = ");
        double xCord = double.Parse(Console.ReadLine());
        Console.Write("Y = ");
        double yCord = double.Parse(Console.ReadLine());

        double radios = 1.5;
        bool isInCircle = (xCord - 1) * (xCord - 1) + (yCord - 1) * ( yCord - 1) <= radios * radios;
        bool isInRectangle = ((xCord <= 5) && (xCord >= -1)) && ((yCord <= 1) && (yCord >= -1));

        Console.WriteLine(((isInCircle == true) && (isInRectangle == false)) ? "yes" : "no");
    }
}