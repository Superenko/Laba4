using System;
using labaa4.Service.Base;
using labaa4.Commands.Base;

namespace labaa4.Commands
{
    public class EditGame : BaseCommand
    {
        private BaseGameService _gameService;

        public EditGame(BaseGameService gameService)
        {
            _gameService = gameService;
        }

        public void Execute()
        {
            Console.WriteLine("Enter game's ID");
            var gameId = int.Parse(Console.ReadLine());
            var selectedGame = _gameService.GetGameById(gameId);

            if (selectedGame == null)
            {
                Console.WriteLine("Game does not exist");
                return;
            }

            Console.WriteLine("Choose what you want to change:");
            Console.WriteLine("1. Game rating");
            Console.WriteLine("2. Player's ID");

            var editChoiceGame = GetChoice(1, 2);

            switch (editChoiceGame)
            {
                case 1:
                    Console.WriteLine("Enter new rating of the game");
                    var newRating = int.Parse(Console.ReadLine());
                    selectedGame.GameRating = newRating;
                    break;
                case 2:
                    Console.WriteLine("Enter new player's ID");
                    var newPlayerId = int.Parse(Console.ReadLine());
                    selectedGame.PlayerId = newPlayerId;
                    break;
            }

            _gameService.UpdateGame(selectedGame);
            Console.WriteLine("Game is updated");
            return;
        }

        private static int GetChoice(int minValue, int maxValue)
        {
            int choice;
            while (true)
            {
                Console.Write($"Enter the number from {minValue} to {maxValue}: ");
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= minValue && choice <= maxValue)
                {
                    break;
                }

                Console.WriteLine("Wrong input");
            }

            return choice;
        }

        public string GetCommandInfo()
        {
            return "Edit the game";
        }
    }
}
