using System;
using labaa4.Repository;
using labaa4.Commands;
using labaa4.Service.Base;
using labaa4.Service;

namespace labaa4.Simulation
{
    public abstract class Simulation
    {
        private static DbContext.DbContext DataBase = new DbContext.DbContext();
        private static PlayerRepository _playerRepository = new PlayerRepository(DataBase);
        private static GameRepository _gameRepository = new GameRepository(DataBase);
        private static GameFactory _gameFactory = new GameFactory();
        private static CommandManager _commandManager = new CommandManager();

        private static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            BasePlayerService playerService = new PlayerService(_playerRepository);
            BaseGameService gameService = new GameService(_gameRepository);

            _commandManager.AddCommand(new CreatePlayer(playerService));
            _commandManager.AddCommand(new DisplayPlayers(playerService));
            _commandManager.AddCommand(new DeletePlayer(playerService));
            _commandManager.AddCommand(new EditPlayer(playerService));
            _commandManager.AddCommand(new DisplayPlayerGames(playerService, gameService));
            _commandManager.AddCommand(new DisplayGames(gameService));
            _commandManager.AddCommand(new EditGame(gameService));
            _commandManager.AddCommand(new DeleteGameCommand(gameService));
            _commandManager.AddCommand(new StartGame(playerService, gameService, _gameFactory));

            Start();
        }

        private static void Start()
        {
            while (true)
            {
                Console.WriteLine("Start:");
                _commandManager.DisplayCommands();

                var startChoice = GetChoice(1, _commandManager.Commands.Count);
                _commandManager.ExecuteCommand(startChoice - 1);
            }
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

                Console.WriteLine("Wrong input,try again");
            }

            return choice;
        }
    }
}
