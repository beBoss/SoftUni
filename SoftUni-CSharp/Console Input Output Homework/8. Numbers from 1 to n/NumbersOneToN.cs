using System;

class NumbersOneToN
{
    static void Main()
    {
        Console.Write("Enter \"n\" =  ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}