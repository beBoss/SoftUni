using System;

class SumNNumbers
{
    static void Main()
    {
        Console.Write("Enter \"n\" = ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += double.Parse(Console.ReadLine());
        }

        Console.WriteLine("The sum is: {0}", sum);
    }
}
