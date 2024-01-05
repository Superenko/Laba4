using labaa4.Essence;
using System.Collections.Generic;
using labaa4.Repository.Base;
using labaa4.Service.Base;

namespace labaa4.Service
{
    public class GameService : BaseGameService
    {
        private readonly BaseGame _gameRepository;

        public GameService(BaseGame gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public void CreateGame(int gameRating)
        {
            var game = new GameEssence { GameRating = gameRating };
            _gameRepository.Create(game);
        }

        public List<GameEssence> GetAllGames()
        {
            return _gameRepository.ReadAll();
        }

        public GameEssence GetGameById(int gameId)
        {
            return _gameRepository.ReadById(gameId);
        }

        public void UpdateGame(GameEssence game)
        {
            _gameRepository.Update(game);
        }

        public void DeleteGame(int gameId)
        {
            _gameRepository.Delete(gameId);
        }
    }
}
