using System;
using System.Collections.Generic;
 
class ZeroSubset
{ 
    static void Main()
    {
        long s = long.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        long[] nums = new long[n];

        for (int i = 0; i < n; i++)
        {
            nums[i] = long.Parse(Console.ReadLine());
        }

        int powNum = (int)Math.Pow((double)2, n) - 1;

        int count = 0;
        for (int i = 1; i <= powNum; i++)
        {
            long sum = 0;
            for (int j = 0; j < n; j++)
            {
                //var1:
                //int mask = 1 << j;
                //int nAndMask = i & mask;
                //int bit = nAndMask >> j;
                int jRightP = i >> j;
                int bit = jRightP & 1;

                if (bit == 1)
                {
                    sum += nums[j];
                }
            }
            if (sum == s)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}