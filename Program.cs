using System;

namespace deckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();
            deck.Print();
            Console.WriteLine("*******************************");
            Console.WriteLine(deck.Deal());
            Console.WriteLine(deck.Deal());
            Console.WriteLine("*******************************");
            deck.Reset();
            deck.Print();
        }
    }
}
