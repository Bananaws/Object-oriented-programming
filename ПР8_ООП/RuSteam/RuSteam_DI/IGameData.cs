using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuSteam_DI
{
    public interface IGameData<T>
    {
        IEnumerable<T> UpdateGameList();
        IEnumerable<T> FindGames(string input);
    }
}
