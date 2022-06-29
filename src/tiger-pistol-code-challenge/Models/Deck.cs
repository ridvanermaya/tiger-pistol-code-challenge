using System;
using System.Collections.Generic;

namespace tiger_pistol_code_challenge
{
    public class Deck : IDeck
    {
        private List<Card> _deck { get; }

        private readonly Random _random;

        /**
         * Constructor
         */
        public Deck()
        {
            _deck = new List<Card>();
            _random = new Random();
        }

        /**
         * Create a deck of cards
         */
        public void Create()
        {
            _deck.Clear();

            var cardSuites = Enum.GetValues(typeof (CardSuites));
            var cardTypes = Enum.GetValues(typeof (CardValues));

            foreach (var cardSuite in cardSuites)
            {
                foreach (var cardType in cardTypes)
                {
                    _deck
                        .Add(new Card((CardSuites) cardSuite,
                            (CardValues) cardType));
                }
            }
        }

        /**
         * shuffle the deck of cards
         * @returns the shuffled deck of cards
         */
        public void Shuffle()
        {
            for (int i = 0; i < _deck.Count; i++)
            {
                var swapIndex = _random.Next(i, _deck.Count);
                var temp = _deck[i];
                _deck[i] = _deck[swapIndex];
                _deck[swapIndex] = temp;
            }
        }

        /*
         * create a function to deal a card
         * removes the card that was dealt from the deck
         * @returns - the card that was dealt
         */
        public Card Deal()
        {
            var card = _deck[0];
            _deck.RemoveAt(0);

            return card;
        }

        /*
         * @returns - the deck of cards
         */
        public List<Card> GetDeck()
        {
            return _deck;
        }

        /**
         * print the card and the remaining cards in the decks
         * @returns deck the remaining cards in the deck
         */
        public void DealAll()
        {
            while (_deck.Count > 0)
            {
                Deal();

                // var card = Deal();

                // Console.WriteLine($"You were dealt the {card.Value} of {card.Suite}, remaining cards in the deck: {_deck.Count}");
            }
        }
    }
}
