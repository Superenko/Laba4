using System;
using labaa4.Service.Base;
using labaa4.Commands.Base;

namespace labaa4.Commands
{
    public class DeletePlayer : BaseCommand
    {
        private BasePlayerService _playerService;

        public DeletePlayer(BasePlayerService playerService)
        {
            _playerService = playerService;
        }

        public void Execute()
        {
            Console.WriteLine("Enter player's ID");
            var answer = Console.ReadLine();

            if (!int.TryParse(answer, out var id))
            {
                Console.WriteLine("Player does not exist");
            }

            var getPlayer = _playerService.GetPlayerById(id);

            if (getPlayer == default)
            {
                Console.WriteLine("Player does not exist");
            }

            _playerService.DeletePlayer(id);
            Console.WriteLine("Player deleted");
        }

        public string GetCommandInfo()
        {
            return "Delete player";
        }
    }
}
