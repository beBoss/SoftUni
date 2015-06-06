using System;

//Problem 16.	* Print Long Sequence

//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … 
//You might need to learn how to use loops in C# (search in Internet).

class PrintLongSequence
{
    static void Main(string[] args)
    {
        for (int i = 2, j = -3; i <= 1000; i += 2, j -= 2)
        {
            if (i == 2)
            {
                Console.Write("{0}, {1}", i, j);
            }
            else
            {
                Console.Write(", {0}, {1}", i, j);
            }
        }
        Console.WriteLine();
    }
}