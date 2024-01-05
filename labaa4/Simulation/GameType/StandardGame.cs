using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaa4.Simulation.GameType
{
    public class StandardGame : Game
    {
        private int _gameRating;

        public StandardGame(int rating)
        {
            _gameRating = rating;
        }

        public override int GetGameRating()
        {
            return _gameRating;
        }

        public override string GetGameType()
        {
            return "Basic game";
        }
    }
}
