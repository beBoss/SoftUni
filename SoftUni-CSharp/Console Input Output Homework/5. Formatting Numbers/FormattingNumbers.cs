using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("a (0 - 500) = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("c = ");
        float c = float.Parse(Console.ReadLine());

        Console.WriteLine("|{0, -10:X}|{1, 10}|{2, 10:F2}|{3, -10:F3}|",
            a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
    }
}