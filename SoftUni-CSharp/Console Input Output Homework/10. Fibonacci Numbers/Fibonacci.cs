using System;

class Fibonacci
{
    public static int GetFibonacciNum(int num)
    {
        if (num == 0)
        {
            return 0;
        }
        else if (num == 1)
        {
            return 1;
        }
        else
        {
            return GetFibonacciNum(num - 2) + GetFibonacciNum(num - 1);
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int count = 0; count < n; count++)
        {
            Console.Write(GetFibonacciNum(count) + " ");
        }
    }
}