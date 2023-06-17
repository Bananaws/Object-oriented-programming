
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuSteam_DIAGRAMS
{
    public class GameDataSql : IGameData<IGame>
    {
        public IEnumerable<IGame> FindGames(string input)
        {
            using (var database = new RuSteamContext())
            {
                List<IGame> foundGames = new List<IGame>();
                foreach (var game in database.Games)
                {
                    if (game.Game_name.ToLower().Contains(input.ToLower()) || game.Game_tags.ToLower().Contains(input.ToLower())
                        || game.Game_price.ToString().ToLower().Contains(input.ToLower()))
                    {
                        foundGames.Add(game);
                    }
                }
                return foundGames;
            }
        }

        public IEnumerable<IGame> UpdateGameList()
        {
            using (var database = new RuSteamContext())
            {
                return database.Games.ToList();
            }
        }
    }
}
