using System;
using System.Linq;
class PlayCard
{
    static void Main()
    {
        Console.Write("Enter a card: ");
        string enteredCard = Console.ReadLine();

        string[] cards = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        if (Array.IndexOf(cards, enteredCard) >= 0)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

        //bool found = false;
        //foreach (string card in cards)
        //{
        //    if (card == enteredCard)
        //    {
        //        found = true;
        //        break;
        //    }
        //}

        //if (found == true)
        //{
        //    Console.WriteLine("yes");
        //}
        //else
        //{
        //    Console.WriteLine("no");
        //}
    }
}