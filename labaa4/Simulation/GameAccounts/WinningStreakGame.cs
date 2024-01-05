using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaa4.Simulation.GameAccounts
{
    public class WinningStreakGame : GameAccount
    {
        private int _consecutiveWins;

        public WinningStreakGame(string userName, int initialRating) : base(userName, initialRating)
        {
            _consecutiveWins = 0;
        }

        protected override int CalculateRatingForWin(int gameRating)
        {
            _consecutiveWins++;
            var bonus = 0;
            if (_consecutiveWins > 1)
            {
                bonus = _consecutiveWins * 10;
            }
            return gameRating + bonus;
        }

        protected override int CalculateRatingForLoss(int gameRating)
        {
            _consecutiveWins = 0;
            return gameRating;
        }

        public override string GetAccountType()
        {
            return "With bonuses for win streak";
        }
    }
}
