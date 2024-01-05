using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaa4.Simulation.GameType
{
    public class TrainingGame : Game
    {
        public override int GetGameRating()
        {
            return 0;
        }
        public override string GetGameType()
        {
            return "Training game";
        }
    }
}
