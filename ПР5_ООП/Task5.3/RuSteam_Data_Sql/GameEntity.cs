using RuSteam_DI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuSteam_Data_Sql
{
    public class GameEntity : IGame
    {
        [Key]
        public string Game_name { get; set; }
        public string Game_tags { get; set; }
        public string Game_description { get; set; }
        public int Game_price { get; set; }
        public GameEntity() { }
        public GameEntity(IGame game)
        {
            Game_name = game.Game_name;
            Game_tags = game.Game_tags;
            Game_description = game.Game_description;
            Game_price = game.Game_price;
        }
    }
}
