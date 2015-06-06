using System;

//Problem 9.	Print a Sequence

//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

class PrintASequence
{
    static void Main()
    {
        for (int i = 2, j = -3; i <= 10; i += 2, j -= 2)
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