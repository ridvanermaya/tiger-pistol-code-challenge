using System;
using System.Collections.Generic;
using tiger_pistol_code_challenge.models;

namespace tiger_pistol_code_challenge
{
    public class DeckOfCards
    {
        /**
         * Constructor
         */
        public DeckOfCards()
        {
        }
        
        /**
         * Create a deck of cards
         * @returns {List<Card>}
         */
        public List<Card> CreateDeck()
        {
            List<Card> deck = new List<Card>();
            List<string> suits = new List<string>() { "Hearts", "Diamonds", "Clubs", "Spades" };
            List<string> values = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            foreach (string suit in suits)
            {
                foreach (string value in values)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Value = value;
                    deck.Add(card);
                }
            }

            return deck;
        }

        /**
         * shuffle the deck of cards
         * @param deck the deck of cards
         * @returns the shuffled deck of cards
         */
        public List<Card> Shuffle(List<Card> deck)
        {
            var random = new Random();

            for (int i = 0; i < deck.Count; i++)
            {
                var swapIndex = random.Next(i, deck.Count);
                var temp = deck[i];
                deck[i] = deck[swapIndex];
                deck[swapIndex] = temp;
            }

            return deck;
        }

        /*
         * create a function to deal a card
         * @param deck - the deck of cards
         * @returns - the card that was dealt
         */
        public Card Deal(List<Card> deck)
        {
            var card = deck[0];
            deck.RemoveAt(0);

            return card;
        }

        /**
         * print the card and the remaining cards in the deck
         * @param card the card that was dealt
         * @returns deck the remaining cards in the deck
         */
        public void DealAll(List<Card> deck)
        {
            while (deck.Count > 0)
            {
                var card = Deal(deck);
                Console.WriteLine($"You were dealt the {card.Value} of {card.Suit}, remaining cards in the deck: {deck.Count}");
            }
        }
    }
}