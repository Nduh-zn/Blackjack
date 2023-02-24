using System.Collections.Generic;
using System.Linq;

namespace Blackjack
{
    // Represents the dealer in the game
    class Dealer
    {
        private List<Card> hand;

        public Dealer()
        {
            hand = new List<Card>();
        }

        public void ReceiveCard(Card card)
        {
            hand.Add(card);
        }

        public string ShowHand()
        {
            // Only show the first card of the dealer's hand
            return $"{hand.First()}, [hidden]";
        }

        public int CalculateHandValue()
        {
            int value = hand.First().Value; // Only consider the first card of the dealer's hand
            int numberOfAces = hand.Count(card => card.Rank == "Ace");

            while (numberOfAces > 0 && value > 21)
            {
                value -= 10;
                numberOfAces--;
            }

            return value;
        }
    }
}
