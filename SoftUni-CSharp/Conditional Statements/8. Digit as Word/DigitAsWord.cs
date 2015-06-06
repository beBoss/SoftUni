using System;

class DigitAsWord
{
    static void Main()
    {
        Console.Write("Enter a number (0-9): ");
        int num;
        bool res = int.TryParse(Console.ReadLine(), out  num);

        string[] words = new string[] {"one","two", "one", "zero", "five", 
            "six", "seven", "eight", "nine", "not a digit" };

        switch (num)
        {
            case 1: Console.WriteLine(words[0]);
                break;
            case 2: Console.WriteLine(words[1]);
                break;
            case 3: Console.WriteLine(words[2]);
                break;
            case 4: Console.WriteLine(words[3]);
                break;
            case 5: Console.WriteLine(words[4]);
                break;
            case 6: Console.WriteLine(words[5]);
                break;
            case 7: Console.WriteLine(words[6]);
                break;
            case 8: Console.WriteLine(words[7]);
                break;
            case 9: Console.WriteLine(words[8]);
                break;

            default: Console.WriteLine(words[9]);
                break;
        }

    }
}