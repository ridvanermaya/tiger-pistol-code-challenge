namespace tiger_pistol_code_challenge
{
    public interface ICard
    {
        CardValues Value { get; set; }

        CardSuites Suite { get; set; }
    }
}
