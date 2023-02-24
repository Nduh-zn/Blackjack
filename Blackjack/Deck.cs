using System;
using System.Collections.Generic;

namespace Blackjack
{
    // Represents a deck of cards
    class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    cards.Add(new Card(suit, rank));
                }
            }
        }

        public void Shuffle()
        {
            Random rng = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card temp = cards[k];
                cards[k] = cards[n];
                cards[n] = temp;
            }
        }

        public Card DealCard()
        {
            if (cards.Count == 0)
            {
                throw new InvalidOperationException("Deck is empty.");
            }

            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

    }

}
