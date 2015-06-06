using System;
using System.Linq;
using System.Collections.Generic;

class MinMaxSumAverage
{
    static void Main()
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;
        int num = 0;

        List<int> numbers = new List<int>();
        
        for (int i = 1; i <= n; i++)
        {
            num = int.Parse(Console.ReadLine());
            numbers.Add(num);
            sum += num;
        }
          
        foreach (var nums in numbers)
        {
            min = (min < nums) ? min : nums;
            max = (max > nums) ? max : nums;
        }

        double avg = numbers.Average();
        Console.WriteLine("min = {0}\r\nmax = {1}\r\nsum = {2}\r\navg = {3:f2}", min, max, sum, avg);
    }
}