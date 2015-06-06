using System;

class FromOneToN
{
    static void Main()
    {
        Console.Write("Enter positive number: ");
        uint num = uint.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            Console.Write("{0}",i);
        }
    }
}