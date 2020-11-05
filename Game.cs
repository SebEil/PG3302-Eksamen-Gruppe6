using System;
using System.Collections.Generic;
using System.Text;

namespace PG3302_Eksamen
{

    enum cards
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
    enum type
    {
        Hearts,
        Diamonds,
        Spades,
        Clubs,
    }

    enum cardsSpecial
    {
        Bomben,
        Gribben,
        Karantene,
        Jokeren
    }

    class Game
    {

        public void print() 
        { 
        Console.WriteLine("Eyyyy");
        }
    }
}
