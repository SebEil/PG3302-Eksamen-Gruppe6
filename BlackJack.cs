using System;

namespace PG3302_Eksamen
{
    class BlackJack
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, and welcome to this card game!! \nHow many players? (2-4)");
            String inpuutPlayer = Console.ReadLine();

            GameBoard game = new GameBoard();
            game.print();



            Console.ReadKey();









        }
    }
}
