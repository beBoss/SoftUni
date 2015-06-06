using System;

//Problem 8.	Prime Number Check

//Write an expression that checks if given positive integer number n (n ≤ 100) 
//is prime (i.e. it is divisible without remainder only to itself and 1). Examples:
//n	Prime?
//1	false
//2	true
//3	true
//4	false
//9	false
//97	true
//51	false
//-3	false
//0	false

class isPrime
{
    //second option
    static bool IsPrimeTwo(int num)
    {
        if ((num & 1) == 0)
            return num == 2;
        if (num < 9)
            return num > 1;

        for (int i = 3; i < num; i += 2)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        sbyte num = sbyte.Parse(Console.ReadLine());

        //first option
        bool isPrime = ((num % 2 != 0) && (num % 3 != 0) && (num % 5 != 0) && (num % 7 != 0) && (num != 1));
        bool primeCases = ((num == 2) || (num == 3) || (num == 5) || (num == 7));
        Console.WriteLine((isPrime || primeCases == true) ? "{0} is prime." : "{0} is not prime.", num);

        //second option
        Console.WriteLine((IsPrimeTwo(num) == true) ? "{0} is prime." : "{0} is not prime.", num);
    }
}