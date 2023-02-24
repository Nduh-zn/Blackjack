using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new deck and shuffle it
            Deck deck = new Deck();
            deck.Shuffle();

            // Create a new player and deal two cards to them
            Player player = new Player();
            player.ReceiveCard(deck.DealCard());
            player.ReceiveCard(deck.DealCard());

            // Create a new dealer and deal two cards to them
            Dealer dealer = new Dealer();
            dealer.ReceiveCard(deck.DealCard());
            dealer.ReceiveCard(deck.DealCard());

            Console.WriteLine($"Player's hand: {player.ShowHand()} (Value: {player.CalculateHandValue()})");
            Console.WriteLine($"Dealer's hand: {dealer.ShowHand()}");

            // Allow the player to hit until they decide to stand or they bust
            while (true)
            {
                Console.Write("Do you want to hit or stand? ");
                string input = Console.ReadLine().ToLower();

                if (input == "hit")
                {
                    Card card = deck.DealCard();
                    player.ReceiveCard(card);
                    Console.WriteLine($"You received a {card}");
                    Console.WriteLine($"Player's hand: {player.ShowHand()} (Value: {player.CalculateHandValue()})");

                    if (player.CalculateHandValue() > 21)
                    {
                        Console.WriteLine("Bust! Dealer wins!");
                        return;
                    }
                }
                else if (input == "stand")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter either 'hit' or 'stand'.");
                }
            }

            // Dealer hits until their hand value is 17 or higher
            while (dealer.CalculateHandValue() < 17)
            {
                Card card = deck.DealCard();
                dealer.ReceiveCard(card);
                Console.WriteLine($"Dealer received a {card}");
                Console.WriteLine($"Dealer's hand: {dealer.ShowHand()}");
            }

            // Determine the winner
            int playerValue = player.CalculateHandValue();
            int dealerValue = dealer.CalculateHandValue();

            if (dealerValue > 21)
            {
                Console.WriteLine("Dealer busts! You win!");
            }
            else if (playerValue > dealerValue)
            {
                Console.WriteLine("You win!");
            }
            else if (dealerValue > playerValue)
            {
                Console.WriteLine("Dealer wins!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }
        
    }

