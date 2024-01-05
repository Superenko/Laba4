using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaa4.Simulation.GameType
{
    public class SoloGame : Game
    {
        private int _playerRating;

        public SoloGame(int playerRating)
        {
            this._playerRating = playerRating;
        }

        public override int GetGameRating()
        {
            return _playerRating;
        }
        public override string GetGameType()
        {
            return "Solo game";
        }
    }
}