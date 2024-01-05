using labaa4.Essence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaa4.Repository.Base
{
    public interface BasePlayer
    {
        void Create(PlayerEssence player);
        List<PlayerEssence> ReadAll();
        PlayerEssence ReadById(int playerId);
        void Update(PlayerEssence player);
        void Delete(int playerId);
    }
}
