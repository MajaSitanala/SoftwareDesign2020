using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1AGameOfCards
{
    class Game
    {
        private List<Player> players_ = new List<Player>();
        private bool isGameStarted = false;

        public Game()
        {
            isGameStarted = true;
        }

        public void addPlayerToGame(string nameOfPlayer)
        {
            players_.Add(new Player(nameOfPlayer));
        }

        public void announceWinner()
        {
            // https://stackoverflow.com/questions/3464934/get-max-value-from-listmytype
            if(players_.Count == 0)
            {
                throw new InvalidOperationException("GAME: No players in game!");
            }

            Player winner = players_[0];

            foreach(Player player in players_)
            {
                if(player.revealValueOfHand() > winner.revealValueOfHand())
                {

                    winner = player;
                }                
            }

            if(!isGameStarted)
            {
                Console.WriteLine("The game haven't started yet!");
            }
            else
            {
                Console.WriteLine("The winner is: " + winner.PlayerName);
            }
        } 

        private void commandDealingOfCards(int numberOfCards)
        {
            
            
        }


    }
}
