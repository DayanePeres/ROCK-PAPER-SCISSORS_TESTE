using System;
using System.Collections.Generic;

namespace ROCK_PAPER_SCISSORS
{
    public class Program
    {     
        static void Main(string[] args)
        {
            string player = "";
            string move = "";
            List<Game> list = new List<Game>();


            Console.WriteLine("****** GAME - ROCK-PAPER-SCISSORS ****** ");

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Player " + (i + 1) + ": ");
                player = Console.ReadLine();

                Console.WriteLine("Move Player " + (i + 1) + ": Choose Between: [R (rock) - P(papper) - S(scissors)]: ");
                move = Console.ReadLine().ToUpper();

                list.Add(new Game(player, move));
            }

            Console.WriteLine("  Winner   !!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("  Player: " + QuickGame.rps_game_winner(list).ToString());
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("***** TOURNAMENT ROCK-PAPER-SCISSORS *****");
            list = new List<Game>();
            list = MultiPlayer.FillList();

            Console.WriteLine("  Winner   !!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("  Player: " + Tournament.rps_tournament_winner(list).ToString()) ;
            Console.ReadKey();

        }
    }
}
