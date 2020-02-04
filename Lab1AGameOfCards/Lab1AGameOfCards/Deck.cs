using Lab1AGameOfCards.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1AGameOfCards
{
    class Deck
    {
        private readonly List<Card> deck_ = new List<Card>();
        private readonly Random random = new Random();

        public Deck()
        {
            for(int i = 1; i <= 8; i++)
            {
                deck_.Add(new RedCard(i));
                deck_.Add(new BlueCard(i));
                deck_.Add(new GreenCard(i));
                deck_.Add(new YellowCard(i));
            }
        }

        public void dealCardsToPlayer(Player player, int numbersToDeal)
        {
            for (int i = 0; i < numbersToDeal; i++)
            {
                //Finds a random number within the range of the size of the List.
                int indexInDeck = random.Next(deck_.Count);

                Card card = deck_[indexInDeck];            
                player.addCardToHand(card);

                deck_.Remove(card);
            }
        }
    }
}
