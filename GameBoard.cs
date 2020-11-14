using System;
using System.Collections.Generic;
using System.Text;

namespace PG3302_Eksamen
{

    enum Card
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
    }
    enum Type
    {
        Hearts,
        Diamonds,
        Spades,
        Clubs,
    }

    enum CardsSpecial
    {
        Bomben,
        Gribben,
        Karantene,
        Jokeren
    }

    class GameBoard
    {
        private readonly HumanPlayer _player;
        private readonly ComputerPlayer _dealer;
        private readonly Random _cardDeck;
        
        public GameBoard()
        {
            _player = new HumanPlayer(this);
            _dealer = new ComputerPlayer(this);
            _cardDeck = new Random();
               }
        
        public void PlayGame()
        {

            do
            {
                Reset();

                _player.InitialHand();
                _player.PerformTurn();

                Console.Write("\n");

                _dealer.InitialHand();

                if ((_player.CurrentTotal <= 21) && (_player.HasBlackJack()){
                    _dealer.PreformTrun();
                }
                DisplayEndGameMessage();
            } while (_player.WantsToKeepPlaying());
        }
    }
}
