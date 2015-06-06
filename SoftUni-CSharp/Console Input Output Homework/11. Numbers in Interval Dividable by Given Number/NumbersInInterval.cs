using System;

class NumbersInInterval
{
    static void Main()
    {
        Console.Write("Enter the start number = ");
        uint numOne = uint.Parse(Console.ReadLine());
        Console.Write("Enter the end number = ");
        uint numTwo = uint.Parse(Console.ReadLine());
        
        
        uint startNum;
        uint endNum;

        if (numOne < numTwo)
        {
            startNum = numOne;
            endNum = numTwo; 
        }
        else
        {
            startNum = numTwo;
            endNum = numOne; 
        }

        bool firstFound = true;

        for (uint i = startNum; i <= endNum; i++)
        {
            if (i % 5 == 0)
            {
                if (firstFound)
                {
                    Console.Write(i);
                    firstFound = false;
                }
                else
                {
                    Console.Write(", " + i);
                }
            }
        }
    }
}