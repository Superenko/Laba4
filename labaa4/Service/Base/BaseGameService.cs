using labaa4.Essence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaa4.Service.Base
{
    public interface BaseGameService
    {   void CreateGame(int gameRating);
        List<GameEssence> GetAllGames();
        GameEssence GetGameById(int gameId);
        void UpdateGame(GameEssence game);
        void DeleteGame(int gameId);
    }
}
