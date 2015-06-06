using System;

class NotDivisibleThreeAndSeven
{
    static void Main()
    {
        Console.Write("Enter a positive number: ");
        uint num = uint.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            if ( !(i % 3 == 0) && !(i % 7 == 0))
            {
                Console.Write("{0, 3}", i);
                
            }
        }
        Console.WriteLine();
    }
}