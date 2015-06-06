using System;

class BeerTime
{
    static bool IsBetween( DateTime time, DateTime startTime, DateTime endTime)
    {
        if (time.TimeOfDay == startTime.TimeOfDay)
            return true;
        if (time.TimeOfDay == endTime.TimeOfDay)
            return false; //softuni wrong check

        if (startTime.TimeOfDay <= endTime.TimeOfDay)
            return (time.TimeOfDay >= startTime.TimeOfDay && time.TimeOfDay <= endTime.TimeOfDay);
        else
            return !(time.TimeOfDay >= endTime.TimeOfDay && time.TimeOfDay <= startTime.TimeOfDay);
    }
    
    static void Main()
    {
        Console.Write("Enter a time (hh:mm tt): ");
        string  isTime = Console.ReadLine();

        DateTime time;
        if (!DateTime.TryParse(isTime, out time))
        {
            Console.WriteLine("Invalid Time");
        }

        DateTime startTime = Convert.ToDateTime("01:00 PM");
        DateTime endTime = Convert.ToDateTime("03:00 AM");

        if ( IsBetween(time, startTime, endTime))
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }
}