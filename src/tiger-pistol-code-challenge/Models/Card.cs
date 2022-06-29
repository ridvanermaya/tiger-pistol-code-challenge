namespace tiger_pistol_code_challenge
{
    public class Card : ICard
    {
        public CardSuites Suite { get; set; }

        public CardValues Value { get; set; }

        public Card(CardSuites suite, CardValues value)
        {
            Suite = suite;
            Value = value;
        }
    }
}
