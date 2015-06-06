using System;

class SortThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter first number = ");
        double firstNum = double.Parse(Console.ReadLine());

        Console.Write("Enter second number = ");
        double secondNum = double.Parse(Console.ReadLine());

        Console.Write("Enter third number = ");
        double thirdNum = double.Parse(Console.ReadLine());

        if (firstNum > secondNum)
        {
            if (firstNum > thirdNum)
            {
                if (secondNum > thirdNum)
                {
                    Console.WriteLine("{0} {1} {2}", firstNum, secondNum, thirdNum);
                }
                else
                {
                    Console.WriteLine("{0} {2} {1}", firstNum, secondNum, thirdNum);
                }
            }
            else
            {
                Console.WriteLine("{2} {0} {1}", firstNum, secondNum, thirdNum);
            }
        }
        else
        {
            if (secondNum > thirdNum)
            {
                if (firstNum > thirdNum)
                {
                    Console.WriteLine("{1} {0} {2}", firstNum, secondNum, thirdNum);
                }
                else
                {
                    Console.WriteLine("{1} {2} {0}", firstNum, secondNum, thirdNum);
                }
            }
            else
            {
                Console.WriteLine("{2} {1} {0}", firstNum, secondNum, thirdNum);
            }
        }
    }
}