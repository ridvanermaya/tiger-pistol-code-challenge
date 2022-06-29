using System;
using Xunit;
using tiger_pistol_code_challenge;

namespace tiger_pistol_code_challenge_test
{
    public class CardTest
    {
        [Fact]
        public void CheckIfTheCardIsCreated()
        {
            var card = new Card(CardSuites.Hearts, CardValues.Ace);
            Assert.NotNull (card);
        }

        [Fact]
        public void CheckIfThe()
        {
            var card = new Card(CardSuites.Hearts, CardValues.Ace);
            Assert.Equal(CardValues.Ace, card.Value);
            Assert.Equal(CardSuites.Hearts, card.Suite);
        }
    }
}
