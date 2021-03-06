using System;
using System.Collections.Generic;

namespace deckOfCards
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; } = new List<Card>();

        public Player(string name)
        {
            Name = name;
        }

        public Card Draw(Deck deck)
        {
            Card drawnCard = deck.Deal();
            Hand.Add(drawnCard);
            Console.WriteLine($"{Name} drew {drawnCard}");
            return drawnCard;
        }

        public void PrintHand()
        {
            Console.WriteLine($"{Name}'s hand is now: ");
            foreach (Card card in Hand)
            {
                Console.WriteLine(card);
            }
        }

        public void Discard(int x)
        {
            if (Hand.Count == 0)
            {
                Console.WriteLine($"There are no cards in {Name}'s hand");
            }

            if (Hand[x] == null)
            {
                Console.WriteLine("That isn't a valid card!");
            }

            Hand[x] = null;
        }
    }
}