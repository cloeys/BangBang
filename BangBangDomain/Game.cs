using System;
using System.Collections;
using System.Collections.Generic;

namespace BangBangDomain
{
    public class Game
    {
        public ICollection<Player> Players { get; set; }
        public PlayingCards Cards { get; set; }
        public ICollection<Player> EliminatedPlayers { get; set; }

        public Game()
        {

        }

    }
}
