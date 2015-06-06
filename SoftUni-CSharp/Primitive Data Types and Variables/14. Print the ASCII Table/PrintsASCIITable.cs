using System;

//Problem 14.	* Print the ASCII Table

//Find online more information about ASCII (American Standard Code for Information Interchange) 
//and write a program to prints the entire ASCII table of characters at the console 
//(characters from 0 to 255). Note that some characters have a special purpose and will 
//not be displayed as expected. You may skip them or display them differently. 
//You may need to use for-loops (learn in Internet how).

class PrintsASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        //skip characters that cannot be displayed "000"
        for (char c = (char)033; c <= (char)255; c++)
        {
            Console.WriteLine(c);
        }

        //or simple way
        //for (int character = 0; character < 255; character++)
        //{
        //    char symbol = (char)character;
        //    Console.WriteLine("{0} -> {1}", character, symbol);

        //}
    }
}