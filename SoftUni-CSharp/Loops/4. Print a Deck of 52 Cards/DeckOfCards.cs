using System;

class DeckOfCards
{
    private static void PrintCards(string card, string cardSign)
    {
        Console.Write("{0}{1} ", card, cardSign);
    }

    static void Main()
    {
        int cardsCount = 14;
        int colours = 4;
        string card;
        string cardSign = "";
        
        for (int i = 2; i <= cardsCount; i++)
        {
            int cardColour = 1;
            if (i < 11)
            {
                card = i.ToString();
            }
            else if (i == 11)
            {
                card = "J";
            }
            else if (i == 12)
            {
                card = "Q";
            }
            else if (i == 13)
            {
                card = "K";
            }
            else
            {
                card = "A";
            }
          
            for (int j = 1; j <= colours; j++)
            {
                switch (cardColour)
                {
                    case 1:
                        cardSign = "♣";
                        break;
                    case 2:
                        cardSign = "♦";
                        break;
                    case 3:
                        cardSign = "♥";
                        break;
                    case 4:
                        cardSign = "♠";
                        break;
                }
                PrintCards(card, cardSign);
                cardColour++;
            }
            Console.WriteLine();
        }
    }
}