using labaa4.Essence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labaa4.Repository.Base;

namespace labaa4.Repository
{
    internal class GameRepository : BaseGame
    {
        private readonly DbContext.DbContext DataBase;

        public GameRepository(DbContext.DbContext dbContext)
        {
            DataBase = dbContext;
        }

        public void Create(GameEssence game)
        {
            game.Id = DataBase.Games.Count + 1;
            DataBase.Games.Add(game);
        }

        public List<GameEssence> ReadAll()
        {
            return DataBase.Games;
        }

        public GameEssence ReadById(int gameId)
        {
            return DataBase.Games.FirstOrDefault(g => g.Id == gameId);
        }

        public void Update(GameEssence game)
        {
            var existingGame = DataBase.Games.FirstOrDefault(g => g.Id == game.Id);
            if (existingGame != null)
            {
                existingGame.GameRating = game.GameRating;
            }
        }

        public void Delete(int gameId)
        {
            var gameToDelete = DataBase.Games.FirstOrDefault(g => g.Id == gameId);
            if (gameToDelete != null)
            {
                DataBase.Games.Remove(gameToDelete);
            }
        }
    }
}
