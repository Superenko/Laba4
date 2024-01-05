using labaa4.Simulation.GameAccounts;

namespace labaa4.Simulation
{
    public class GameFactory
    {
        public static GameAccount CreateStandardGameAccount(string userName, int initialRating)
        {
            return new StandardGameAccount(userName, initialRating);
        }

        public static GameAccount CreateReducedLossGameAccount(string userName, int initialRating)
        {
            return new ReducedLossGame(userName, initialRating);
        }

        public static GameAccount CreateWinningStreakGameAccount(string userName, int initialRating)
        {
            return new WinningStreakGame(userName, initialRating);
        }
    }
}