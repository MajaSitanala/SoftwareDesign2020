using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1AGameOfCards
{
    class Player
    {
        private string playerName_;
        private List<Card> hand_ = new List<Card>();

        public Player(string playerName)
        {
            playerName_ = playerName;
        }

        public void addCardToHand(Card card)
        {
            hand_.Add(card);
        }

        public int revealValueOfHand()
        {
            int valueOfHand = 0;

            foreach (Card card in hand_)
            {
                valueOfHand += card.GetValue();
            }

            return valueOfHand;
        }

        public void showHand()
        {
            foreach (Card card in hand_)
            {
                Console.WriteLine(card.SuitName + $"no {0}\n", card.Number);
            }
        }
    }
}
