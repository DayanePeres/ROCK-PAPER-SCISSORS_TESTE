using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ROCK_PAPER_SCISSORS
{
    public class Validations
    {
        public static bool ValidPlayer(string player)
        {
            return (!string.IsNullOrEmpty(player) && !string.IsNullOrWhiteSpace(player)); 
        }

        public static bool ValidMove(string move)
        {
            var test = new string[] { "P", "R", "S" };

            return test.Contains(move);
        }
    }
}
