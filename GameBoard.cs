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

                if ((_player.CurrentTotal <= 21) && (_player.HasBlackJack())){
                    _dealer.PreformTrun();
                }
                DisplayEndGameMessage();
            } while (_player.WantsToKeepPlaying());

        }
        public Card DealCard()

        {
            int cardValue = _cardDeck.Next(1, 13);
            return (Card)cardValue;

        }

        private void Reset()
        {
            _player.Reset();

            _dealer.Reset();

            Console.Clear();
        }

        private void DisplayEndMessage() {
            if (_player.HasBlackJack()) {
                Console.WriteLine(" \n You Won: You got BlackJack!");
            } else if (_player.CurrentTotal > 21) {
                Console.WriteLine(" \n You busted, so you lost.");
            } else if (_dealer.CurrentTotal > 21) {
                Console.WriteLine(" \n The dealer busted, so you won! (The drealer's total was {0}.)", _dealer.CurrentTotal);
            } else if (_player.CurrentTotal > _dealer.CurrentTotal) {
                Console.WriteLine(" \n You won! (Your   total was {0},the Dealer dealer's total was {1}.)", _player.CurrentTotal);
            } else {
                Console.WriteLine(" \n You lost. (Your   total was {0},the Dealer dealer's total was {1}.)", _player.CurrentTotal); }
        }
    }
}
