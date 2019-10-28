using System;
using System.Collections.Generic;

namespace ROCK_PAPER_SCISSORS
{
    class Program
    {

        private static bool ValidPlayer(string player)
        {
            return string.IsNullOrEmpty(player) || string.IsNullOrWhiteSpace(player);            
        }

        private static bool ValidMove(string move)
        {
            return move.Equals("R") || move.Equals("P") || move.Equals("S");
        }
        
        private static Game Winner(List<Game> games)
        {
            for (int i = 0, j = 1; i  < games.Count; i++, j++)
            {
                if (games[i].Move.Equals("R") && games[j].Move.Equals("S"))
                {
                    games.Remove(games[j]);
                    return games[i];
                }                    
                if (games[i].Move.Equals("P") && games[j].Move.Equals("R"))
                {
                    games.Remove(games[j]);
                    return games[i];
                }
                    
                if (games[i].Move.Equals("S") && games[j].Move.Equals("P"))
                {
                    games.Remove(games[j]);
                    return games[i];
                }
                    
                if (games[i].Move.Equals(games[j].Move))
                {
                    games.Remove(games[j]);
                    return games[i];
                }
                else
                {
                    games.Remove(games[i]);
                    return games[i];
                }
                
            }
            return games[0];

        }

        public static Game rps_game_winner(List<Game> games) //Part A
        {

            if (games.Count == 2)
            {
                if (ValidMove(games[0].Move) && ValidMove(games[1].Move))
                {

                    return Winner(games);
                }
                else
                {
                    throw new System.ArgumentException("NoSuchStrategyError");
                }
            }
            else
            {
                throw new System.ArgumentException("WrongNumberOfPlayersError");
            }

        }

        private static Game rps_tournament_winner(List<Game> list) // Part B
        {
            int i = 0;
            int listInt = list.Count;
            List<Game> listWinners = new List<Game>();

            while(list.Count != 1)
            {                
                listWinners.Add(Winner(list));
                list.Remove(list[i]);

                listInt = list.Count;

                if (listInt == 0)
                {
                    listInt = listWinners.Count;
                    list = listWinners;
                    listWinners = new List<Game>();
                }              
                
            }  
            return list[0];
        }

        private static List<Game> FillList()
        {            
            List<Game> list = new List<Game>();

            list.Add(new Game("Dave", "S"));
            list.Add(new Game("Armando", "P"));

            list.Add(new Game("Richard", "R"));
            list.Add(new Game("Michael", "S"));

            list.Add(new Game("Allen", "S"));
            list.Add(new Game("Omer", "P"));

            list.Add(new Game("David E", "R"));
            list.Add(new Game("Richard X", "P"));

            return list;
        }

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

            Console.WriteLine("Winner   !!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("Player: " + rps_game_winner(list).ToString());
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("***** TOURNAMENT ROCK-PAPER-SCISSORS *****");
            list = new List<Game>();
            list = FillList();

            Console.WriteLine("Winner   !!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("Player: " + rps_tournament_winner(list).ToString());
            Console.ReadKey();

        }
    }
}
