using System;
using System.Collections.Generic;

namespace deckOfCards
{
    public class Deck
    {
        public List<Card> Cards { get; set; } = new List<Card>();

        public Deck()
        {
            string[] suits = new string[]
            {
                "Clubs", "Spades", "Hearts", "Diamonds"
            };

            Dictionary<int, string> face = new Dictionary<int, string>()
            {
                {1, "Ace"},
                {11, "Jack"},
                {12, "Queen"},
                {13, "King"},
            };

            foreach (string suit in suits)
            {
                for (int i = 1; i <= 13; i++)
                {
                    Card card = new Card(i.ToString(), suit, i);
                    Cards.Add(card);
                }
            }
        }
        public void Print()
        {
            foreach (Card card in Cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}