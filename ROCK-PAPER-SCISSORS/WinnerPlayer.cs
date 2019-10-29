using System;
using System.Collections.Generic;
using System.Text;

namespace ROCK_PAPER_SCISSORS
{
    public class WinnerPlayer
    {
        public static Game Winner(List<Game> games)
        {
            for (int i = 0, j = 1; i < games.Count; i++, j++)
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
    }
}
