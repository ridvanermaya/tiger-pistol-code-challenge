namespace tiger_pistol_code_challenge
{
    public interface IDeck
    {
        void Create();

        void Shuffle();

        Card Deal();

        void DealAll();
    }
}
