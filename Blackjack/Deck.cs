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
            string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };

            cards = new List<Card>();
            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    int value;
                    if (rank == "Ace")
                    {
                        value = 11;
                    }
                    else if (rank == "King" || rank == "Queen" || rank == "Jack")
                    {
                        value = 10;
                    }
                    else
                    {
                        value = int.Parse(rank);
                    }

                    cards.Add(new Card(rank, suit, value));
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
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }
    }
}
