using System;
using System.Collections.Generic;
using System.Text;

namespace ROCK_PAPER_SCISSORS
{
    public class QuickGame
    {
        public static Game rps_game_winner(List<Game> games) //Part A
        {
            if (games.Count == 2)
            {
                for (int i = 0; i < games.Count; i++)
                {
                    if (Validations.ValidPlayer(games[i].Player) && Validations.ValidMove(games[i].Move))
                    {
                        if(i == games.Count -1)
                            return WinnerPlayer.Winner(games);
                    }
                    else
                    {
                        throw new System.ArgumentException("NoSuchStrategyError");
                    }
                    
                }
                throw new System.ArgumentException("NoSuchStrategyError");
            }
            else
            {
                throw new System.ArgumentException("WrongNumberOfPlayersError");
            }

        }
    }
}
