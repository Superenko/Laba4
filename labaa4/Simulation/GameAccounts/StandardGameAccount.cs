using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaa4.Simulation.GameAccounts
{
    public class StandardGameAccount : GameAccount
    {
        public StandardGameAccount(string userName, int initialRating) : base(userName, initialRating)
        {
        }

        protected override int CalculateRatingForWin(int gameRating)
        {
            return gameRating;
        }

        protected override int CalculateRatingForLoss(int gameRating)
        {
            return gameRating;
        }

        public override string GetAccountType()
        {
            return "Basic";
        }
    }
}
