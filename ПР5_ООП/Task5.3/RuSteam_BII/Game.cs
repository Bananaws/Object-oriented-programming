using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RuSteam_DI;
namespace RuSteam_BII
{
    public class Game : IGame
    {
        public string Game_name { get ; set; }
        public string Game_tags { get; set; }
        public string Game_description { get; set; }
        public int Game_price { get; set; }

    }
}
