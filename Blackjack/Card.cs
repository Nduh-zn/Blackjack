namespace Blackjack
{
    // Represents a card in a standard deck of playing cards
    public class Card
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }

        public Card(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public int Value
        {
            get
            {
                switch (Rank)
                {
                    case Rank.Ace:
                        return 11;
                    case Rank.Jack:
                    case Rank.Queen:
                    case Rank.King:
                        return 10;
                    default:
                        return (int)Rank;
                }
            }
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }

    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Rank
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

}
