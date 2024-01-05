using labaa4.Essence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaa4.DbContext
{
    public class DbContext
    {
        public List<PlayerEssence> Players { get; set; }
        public List<GameEssence> Games { get; set; }

        public DbContext()
        {
            Players = new List<PlayerEssence>();
            Games = new List<GameEssence>();

            Players.Add(new PlayerEssence { Id = 1, UserName = "Player1", CurrentRating = 10, GamesCount = 0 });
            Players.Add(new PlayerEssence { Id = 2, UserName = "Player2", CurrentRating = 10, GamesCount = 0 });
        }
    }
}
