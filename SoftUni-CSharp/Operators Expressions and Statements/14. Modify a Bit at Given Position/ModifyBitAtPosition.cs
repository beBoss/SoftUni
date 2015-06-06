using System;

//Problem 14.	Modify a Bit at Given Position

//We are given an integer number n, a bit value v (v=0 or 1) and a position p. 
//Write a sequence of operators (a few lines of C# code) that modifies n to hold 
//the value v at the position p from the binary representation of n
//while preserving all other bits in n. Examples:
//n	    binary representation of n	p	v	binary result	    result
//5	    00000000 00000101	        2	0	00000000 00000001	1
//0	    00000000 00000000	        9	1	00000010 00000000	512
//15	00000000 00001111	        1	1	00000000 00001111	15
//5343	00010100 11011111	        7	0	00010100 01011111	5215
//62241	11110011 00100001	        11	0	11110011 00100001	62241

class ModifyBitAtPosition
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("Enter a position: ");
        int pos = int.Parse(Console.ReadLine());

        Console.Write("Enter a value (0 or 1): ");
        int val = int.Parse(Console.ReadLine());

        if (val == 1)
        {
            int mask = 1 << pos;
            int bit = num | mask;
            Console.WriteLine(bit);
        }
        else
        {
            int mask = ~(1 << pos);
            int bit = num & mask;
            Console.WriteLine(bit);
        }
    }
}