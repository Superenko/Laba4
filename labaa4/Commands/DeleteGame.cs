using System;
using labaa4.Service.Base;
using labaa4.Commands.Base;

namespace labaa4.Commands
{
    public class DeleteGameCommand : BaseCommand
    {
        private BaseGameService _gameService;

        public DeleteGameCommand(BaseGameService gameService)
        {
            _gameService = gameService;
        }

        public void Execute()
        {
            var gameId = GetGameIdFromUserInput();
            _gameService.DeleteGame(gameId);
            Console.WriteLine("Game was successfully deleted");
        }

        private int GetGameIdFromUserInput()
        {
            int gameId;

            while (true)
            {
                Console.Write("Enter game's ID: ");

                if (int.TryParse(Console.ReadLine(), out gameId))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid numeric ID.");
                }
            }

            return gameId;
        }

        public string GetCommandInfo()
        {
            return "Delete game";
        }
    }
}
