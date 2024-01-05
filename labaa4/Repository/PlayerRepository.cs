using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labaa4.Essence;
using labaa4.Repository.Base;

namespace labaa4.Repository
{
    internal class PlayerRepository : BasePlayer
    {
        private DbContext.DbContext DataBase;

        public PlayerRepository(DbContext.DbContext dbContext)
        {
            DataBase = dbContext;
        }

        public void Create(PlayerEssence player)
        {
            player.Id = DataBase.Players.Count + 1;
            player.UserName = "Player" + (DataBase.Players.Count + 1);
            DataBase.Players.Add(player);
        }

        public List<PlayerEssence> ReadAll()
        {
            return DataBase.Players;
        }

        public PlayerEssence ReadById(int playerId)
        {
            return DataBase.Players.FirstOrDefault(p => p.Id == playerId);
        }

        public void Update(PlayerEssence player)
        {
            var existingPlayer = DataBase.Players.FirstOrDefault(p => p.Id == player.Id);
            if (existingPlayer != null)
            {
                existingPlayer.UserName = player.UserName;
                existingPlayer.CurrentRating = player.CurrentRating;
                existingPlayer.GamesCount = player.GamesCount;
            }
        }

        public void Delete(int playerId)
        {
            var playerToDelete = DataBase.Players.FirstOrDefault(p => p.Id == playerId);
            if (playerToDelete != null)
            {
                DataBase.Players.Remove(playerToDelete);
            }
        }
    }
}
