using System;
using System.Collections.Generic;
using System.Text;

namespace ROCK_PAPER_SCISSORS
{
    public class Tournament
    {
        public static Game rps_tournament_winner(List<Game> list) // Part B
        {
            int i = 0;
            int listInt = list.Count;
            List<Game> listWinners = new List<Game>();

            while (list.Count != 1)
            {
                listWinners.Add(WinnerPlayer.Winner(list));
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

    }
}
