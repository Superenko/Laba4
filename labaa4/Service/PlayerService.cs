using System.Collections.Generic;
using labaa4.Repository.Base;
using labaa4.Essence;
using labaa4.Service.Base;

namespace labaa4.Service
{
    public class PlayerService : BasePlayerService
    {
        private readonly BasePlayer _playerRepository;

        public PlayerService(BasePlayer playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public void CreatePlayer(string userName, int initialRating)
        {
            var player = new PlayerEssence { UserName = userName, CurrentRating = initialRating, GamesCount = 0 };
            _playerRepository.Create(player);
        }

        public List<PlayerEssence> GetAllPlayers()
        {
            return _playerRepository.ReadAll();
        }

        public PlayerEssence GetPlayerById(int playerId)
        {
            return _playerRepository.ReadById(playerId);
        }

        public void UpdatePlayer(PlayerEssence player)
        {
            _playerRepository.Update(player);
        }

        public void DeletePlayer(int playerId)
        {
            _playerRepository.Delete(playerId);
        }
    }
}