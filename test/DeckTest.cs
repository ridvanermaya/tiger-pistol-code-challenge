using System;
using Xunit;
using tiger_pistol_code_challenge;

namespace tiger_pistol_code_challenge_test
{
    public class DeckTest
    {
        [Fact]
        public void CheckIfTheDeckIsCreated()
        {
            var deck = new Deck();
            Assert.NotNull (deck);
        }

        [Fact]
        public void CheckIftheDeckContains52Cards()
        {
            var deck = new Deck();
            deck.Create();
            Assert.Equal(52, deck.GetDeck().Count);
        }

        [Fact]
        public void CheckIfOneCardIsDealt()
        {
            var deck = new Deck();
            deck.Create();
            deck.Shuffle();
            var card = deck.Deal();
            Assert.Equal(51, deck.GetDeck().Count);
        }

        [Fact]
        public void CheckIfAllCardsAreDealt()
        {
            var deck = new Deck();
            deck.Create();
            deck.Shuffle();
            deck.DealAll();
            Assert.Equal(0, deck.GetDeck().Count);
        }

        [Fact]
        public void CheckIfTheDeckIsShuffled()
        {
            var deckOne = new Deck();
            deckOne.Create();

            var unshuffledDeck = deckOne.GetDeck();

            var deckTwo = new Deck();

            deckTwo.Create();
            deckTwo.Shuffle();

            Assert.NotEqual(unshuffledDeck, deckTwo.GetDeck());
        }
    }
}
