using System;
using System.Collections.Generic;
using System.Text;

namespace PG3302_Eksamen
{
    abstract class Player
    {
        private readonly GameBoard _game;

        private Card LatestDrawCard;


        protected int SoftAcesCount;

        public int CurrentTotal { get; set; }
        public int CardCount { get; set; }

        protected Player(GameBoard game)
        {
            _game = game;

        }
        public void Reset ()
        {
            CurrentTotal = 0;
            CardCount = 0;
            SoftAcesCount = 0;
        }

        public void InitialHand()
        {
            DrawCard();
             DrawCard();
        }

        public void PeformTurn()
        {
            while (ShouldDrawAnotherCard())
                DrawCard();
            {

            }

        }

        protected abstract bool ShouldDrawAnotherCard();

        protected virtual void DrawCard()
        {
            LatestDrawCard = _game.DealCard();
            UpdateCardValues(LatestDrawCard);
        }
        private void UpdateCardValues(Card cards);


    }
}
