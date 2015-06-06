using System;

class SumFiveNumbers
{
    static void Main()
    {
        Console.Write("Enter numbers: ");
        string[] numbers = Console.ReadLine().Split(' ');

        double sum = 0;
        for (int i = 0; i <= (numbers.Length - 1); i++)
        {
            sum += double.Parse(numbers[i]);
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}
