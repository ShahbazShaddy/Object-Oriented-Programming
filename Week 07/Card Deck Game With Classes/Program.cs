using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Deck_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the High-Low card game!");
            Console.WriteLine("You will be shown a card, and you have to guess if the next card is higher or lower.");
            Console.WriteLine("Let's begin!");

            var deck = new Deck();
            deck.Shuffle();

            int score = 0;
            bool gameOver = false;
            Card currentCard = deck.DealCard();

            while (!gameOver)
            {
                Console.WriteLine();
                Console.WriteLine($"Current card: {currentCard}");
                Console.Write("Is the next card higher (H) or lower (L)? ");

                string input = Console.ReadLine().ToUpper();
                if (input == "H" || input == "L")
                {
                    Card nextCard = deck.DealCard();

                    if (nextCard == null)
                    {
                        Console.WriteLine("No more cards left in the deck. Game over!");
                        gameOver = true;
                    }
                    else
                    {
                        Console.WriteLine($"Next card: {nextCard}");

                        if ((input == "H" && IsHigher(nextCard, currentCard)) || (input == "L" && IsLower(nextCard, currentCard)))
                        {
                            score++;
                            Console.WriteLine("Correct!");
                            currentCard = nextCard;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect! Game over.");
                            gameOver = true;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter 'H' for higher or 'L' for lower.");
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Your score: {score}");
        }

        private static bool IsHigher(Card card1, Card card2)
        {
            List<string> values = new List<string> { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            return values.IndexOf(card1.Value) > values.IndexOf(card2.Value);
        }

        private static bool IsLower(Card card1, Card card2)
        {
            List<string> values = new List<string> { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            return values.IndexOf(card1.Value) < values.IndexOf(card2.Value);
        }

    }
}
