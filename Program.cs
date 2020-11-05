using System;

namespace PG3302_Eksamen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, and welcome to this card game!! \nHow many players? (2-4)");
            String inpuutPlayer = Console.ReadLine();

            Game game = new Game();
            game.print();



            Console.ReadKey();









        }
    }
}
