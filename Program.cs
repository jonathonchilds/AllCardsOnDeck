using System;
using System.Collections.Generic;
namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var suits = new List<string>() { "Hearts", "Diamonds", "Spades", "Clubs" };
            var ranks = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            var deck = new List<string>();

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    deck.Add($"{rank} of {suit}");
                }
            }

            var deckLength = deck.Count;

            for (var rightIndex = deckLength - 1; rightIndex >= 1; rightIndex--)
            {
                var randomNumberGenerator = new Random();
                var leftIndex = randomNumberGenerator.Next(rightIndex);

                var leftCard = deck[leftIndex];
                var rightCard = deck[rightIndex];
                deck[rightIndex] = leftCard;
                deck[leftIndex] = rightCard;
            }
            var firstCard = deck[0];
            Console.WriteLine(firstCard);
            var secondCard = deck[1];
            Console.WriteLine(secondCard);
        }
    }
}