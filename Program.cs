using System;

namespace deckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();

            Player player = new Player("Buddy");
            player.Draw(deck);
            player.Draw(deck);
            player.PrintHand();
        }
    }
}
