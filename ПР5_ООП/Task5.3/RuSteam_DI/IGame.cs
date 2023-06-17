using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuSteam_DI
{
    public interface IGame
    {
        string Game_name { get; set; }
        string Game_tags { get; set; }
        string Game_description { get; set; }
        int Game_price { get; set; }
    }
}
