using System;
using System.Linq;

//Problem 6.	Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
//•	Prints on the console the number in reversed order: dcba (in our example 1102).
//•	Puts the last digit in the first position: dabc (in our example 1201).
//•	Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0. Examples:
//n	sum of digits	reversed	last digit in front	second and third digits exchanged
//2011	4	1102	1201	2101
//3333	12	3333	3333	3333
//9876	30	6789	6987	9786

public static class ReplaceAtExtensions
{
    public static string ReplaceAtChars(this string source, int index, char replacement)
    {
        var temp = source.ToCharArray();
        temp[index] = replacement;
        return new String(temp);
    }
}

class FourDigitNumber
{
    public static string ReverseXor(string s)
    {
        char[] charArray = s.ToCharArray();
        int len = s.Length - 1;

        for (int i = 0; i < len; i++, len--)
        {
            charArray[i] ^= charArray[len];
            charArray[len] ^= charArray[i];
            charArray[i] ^= charArray[len];
        }

        return new string(charArray);
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int sum = 0;
        // option 1
        //for (int n = number; n > 0; sum += n % 10, n /= 10);

        // option 2
        //sum = number.ToString().Sum(c => Convert.ToInt32(c.ToString()));

        // option 3 -> Linq
        sum = number.ToString().Sum(c => c - '0');
        Console.WriteLine("Sum of digits: {0}", sum);

        Console.WriteLine("Reversed: {0}", ReverseXor(number.ToString()));

        string digitInFront = number.ToString().Substring(3, 1) + number.ToString().Substring(0, 3);
        Console.WriteLine("Last digit in front: {0}", digitInFront);

        Console.WriteLine("Second and third digits exchanged: {0}",
            number.ToString()
                  .ReplaceAtChars(1, number.ToString().ToCharArray()[2])
                  .ReplaceAtChars(2, number.ToString().ToCharArray()[1]));
    }
}