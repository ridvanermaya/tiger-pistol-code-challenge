using System;

namespace tiger_pistol_code_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var deckOfCards = new DeckOfCards();

            var deck = deckOfCards.CreateDeck();

            deck = deckOfCards.Shuffle(deck);

            deckOfCards.DealAll(deck);
        }
    }
}
