using labaa4.Essence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaa4.Repository.Base
{
     public interface BaseGame 
    { 
    void Create(GameEssence game);
    List<GameEssence> ReadAll();
    GameEssence ReadById(int gameId);
    void Update(GameEssence game);
    void Delete(int gameId);

    }
}