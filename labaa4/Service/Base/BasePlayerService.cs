using labaa4.Essence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaa4.Service.Base
{
    public interface BasePlayerService
    {
        void CreatePlayer(string userName, int initialRating);
        List<PlayerEssence> GetAllPlayers();
        PlayerEssence GetPlayerById(int playerId);
        void UpdatePlayer(PlayerEssence player);
        void DeletePlayer(int playerId);
    }
}