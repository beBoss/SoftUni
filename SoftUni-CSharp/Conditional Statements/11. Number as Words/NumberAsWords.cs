using System;

//Problem 11.	* Number as Words

//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. Examples:
//numbers	number as words
//0 	    Zero
//9	        Nine
//10	    Ten
//12	    Twelve
//19	    Nineteen
//25	    Twenty five
//98	    Ninety eight
//273	    Two hundred and seventy three
//400	    Four hundred
//501	    Five hundred and one
//617	    Six hundred and seventeen
//711	    Seven hundred and eleven
//999	    Nine hundred and ninety nine

class NumberAsWords
{
    static string UppercaseFirst(string s)
    {
        char[] a = s.ToCharArray();
        a[0] = char.ToUpper(a[0]);
        return new string(a);
    }

    static void Main()
    {
        string[] words =
        {
            "zero", "one", "two", "three", "four", "five", "six",
            "seven", "eight", "nine", "ten", "eleven", "twelve",
            "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
            "eighteen", "nineteen", "twenty", "thirty", "forty",
            "fifty", "sixty", "seventy", "eighty", "ninety", "hundred"
        };

        Console.Write("Enter a number [0…999] : ");

        ushort num;
        if (!ushort.TryParse(Console.ReadLine(), out num))
        {
            Console.WriteLine("The input isn't a number!");
        }
        else
        {
            if ((num > 99) && (num < 1000))
            {
                Console.WriteLine(
                    (double)num / (num / 100) == 100 ? 
                    UppercaseFirst(words[num / 100]) + " " + words[words.Length - 1] :
                    UppercaseFirst(words[num / 100]) + " " + words[words.Length - 1] + " " +
                    (num % 100 / 10 == 0 ? "and" + " " + words[num % 10] : (num % 100 < 21 ? "and " +
                                                                                                                                                                               words[(num % 100)] : "and " + words[18 + (num % 100 / 10)] + " " + (num % 10 != 0 ? words[num % 10] : " "))));
            }
            else if (num < 100)
            {
                Console.WriteLine(num % 100 / 10 == 0 ?
                    UppercaseFirst(words[num % 10]) : (num < 21 ? UppercaseFirst(words[num]) :
                    UppercaseFirst(words[18 + (num % 100 / 10)]) + " " + 
                    (num % 10 != 0 ? words[num % 10] : " ")));
            }
            else
            {
                Console.WriteLine("The number is bigger then 1000!");
            }
        }
    }
}