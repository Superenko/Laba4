using System;
using labaa4.Service.Base;
using labaa4.Commands.Base;

namespace labaa4.Commands
{
    public class DisplayGames : BaseCommand
    {
        private BaseGameService _gameService;

        public DisplayGames(BaseGameService gameService)
        {
            _gameService = gameService;
        }

        public void Execute()
        {
            Console.WriteLine("List of all played games:");

            foreach (var gameEntity in _gameService.GetAllGames())
            {
                Console.WriteLine(
                    $"Game's ID {gameEntity.Id}, game rating {gameEntity.GameRating}, game type {gameEntity.GameType}, account type {gameEntity.AccountType}, Win: {gameEntity.IsWin}");
            }
        }

        public string GetCommandInfo()
        {
            return "List of games";
        }
    }
}