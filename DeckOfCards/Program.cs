namespace DeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Deck Of Card");
            PlayCards playCards = new PlayCards();
            playCards.ShuffleCards();
        }
    }
}