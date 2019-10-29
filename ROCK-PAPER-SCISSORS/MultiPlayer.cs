using System;
using System.Collections.Generic;
using System.Text;

namespace ROCK_PAPER_SCISSORS
{
    public class MultiPlayer
    {   public static List<Game> FillList()
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
    }
}
