# Blackjack 21
this is the code for a console app in C# that implements the logic and rules of 21 Blackjack using Object-Oriented Programming (OOP) principles.


Objective
The objective of Blackjack is to beat the dealer by having a hand that is worth more points than the dealer's hand, without exceeding 21 points.

Rules of the Game
Aces can be worth 1 or 11 points, face cards (Jack, Queen, and King) are worth 10 points, and all other cards are worth their face value.

Each player (including the dealer) is dealt two cards, one at a time. The players' cards are dealt face up, while the dealer's first card is dealt face down (hole card) and the second card is dealt face up.

The player can choose to "hit" (draw another card) or "stand" (keep their current hand). The player can continue to hit until they decide to stand, or their hand exceeds 21 points (bust).

After all the players have completed their turn, the dealer reveals their hole card. If the dealer's hand is worth less than 17 points, they must hit until their hand is worth at least 17 points.

If the dealer's hand exceeds 21 points, all remaining players win. Otherwise, the dealer compares their hand to each player's hand to determine the winner. 
The player's hand must be worth more points than the dealer's hand without exceeding 21 points to win.


Game Logic
The game starts by shuffling the deck of cards.

Each player, including the dealer, is dealt two cards.

The player can choose to hit or stand. If the player's hand exceeds 21 points, they lose.

After all the players have completed their turn, the dealer reveals their hole card and hits until their hand is worth at least 17 points.

If the dealer's hand exceeds 21 points, all remaining players win. Otherwise, the dealer compares their hand to each player's hand to determine the winner. The player's hand must be worth more points than the dealer's hand without exceeding 21 points to win.

If the player's hand is worth the same number of points as the dealer's hand, the game is a tie (push).

The game ends when all players have completed their turn and the winner is determined.

Additional Features
The game should keep track of the player's total wins and losses.

The game should allow the player to quit at any time.

The game should have an option to play again.

The game should display the player's hand and the dealer's hand after each turn.

The game should display the outcome of each game (win, loss, or tie).
