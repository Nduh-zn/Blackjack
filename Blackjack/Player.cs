using System.Collections.Generic;
using System.Linq;

namespace Blackjack
{
    // Represents a player in the game
    class Player
    {
        private List<Card> hand = new List<Card>();

        public void ReceiveCard(Card card)
        {
            hand.Add(card);
        }

        public string ShowHand()
        {
            string handString = "";
            foreach (Card card in hand)
            {
                handString += card.ToString() + ", ";
            }
            return handString.Substring(0, handString.Length - 2);
        }

        public int CalculateHandValue()
        {
            int handValue = 0;
            int numAces = 0;

            foreach (Card card in hand)
            {
                if (card.Rank == Rank.Ace)
                {
                    numAces++;
                }
                else if (card.Rank == Rank.Jack || card.Rank == Rank.Queen || card.Rank == Rank.King)
                {
                    handValue += 10;
                }
                else
                {
                    handValue += (int)card.Rank;
                }
            }

            for (int i = 0; i < numAces; i++)
            {
                if (handValue + 11 <= 21)
                {
                    handValue += 11;
                }
                else
                {
                    handValue += 1;
                }
            }

            return handValue;
        }
    }

}
