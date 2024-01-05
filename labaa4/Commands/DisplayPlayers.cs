using System;
using labaa4.Service.Base;
using labaa4.Commands.Base;

namespace labaa4.Commands
{
    public class DisplayPlayers : BaseCommand
    {
        private BasePlayerService _playerService;

        public DisplayPlayers(BasePlayerService playerService)
        {
            _playerService = playerService;
        }

        public void Execute()
        {
            foreach (var player in _playerService.GetAllPlayers())
            {
                Console.WriteLine($"Player's ID {player.Id}, name {player.UserName}, current rating {player.CurrentRating}, amount of player's games {player.GamesCount}");
            }
        }

        public string GetCommandInfo()
        {
            return "List of players";
        }
    }
}
