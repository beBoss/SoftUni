using System;

//Problem 2.	Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth. 
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth. Examples:
//86	14.62
//74.6	12.682
//53.7	9.129


class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Enter the weight: ");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine("Weight on the Moon: {0}", weight / 100 * 17);
    }
}