using System;
using System.Collections.Generic;
using System.Text;

namespace ROCK_PAPER_SCISSORS
{
    public class Game
    {
        public string Player { get; set; }
        public string Move { get; set; }

        public Game(){
        }

        public Game(string player, string move)
        {
            Player = player;
            Move = move;
        }

        public override string ToString()
        {
            return Player.ToString();
        }
    }
}
