using System;
using labaa4.Essence;
using labaa4.Service.Base;
using labaa4.Commands.Base;

namespace labaa4.Commands
{
    public class CreatePlayer : BaseCommand
    {
        private BasePlayerService _playerService;

        public CreatePlayer(BasePlayerService playerService)
        {
            _playerService = playerService;
        }

        public void Execute()
        {
            var newPlayer = new PlayerEssence();
            _playerService.CreatePlayer(newPlayer.UserName, newPlayer.CurrentRating);

            Console.WriteLine($"Player was created");
        }

        public string GetCommandInfo()
        {
            return "Create player";
        }
    }
}
