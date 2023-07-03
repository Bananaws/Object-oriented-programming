using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace RuSteam_DIAGRAMS
{
    public delegate void AccountHandler(IShop sender, AccountEventArgs e);
    public interface IShop
    {
        static string? str { get; set; }

        event AccountHandler? Notify;
        IEnumerable<IGame> GetAllGames();
        IEnumerable<IGame> FindGames(string input);
        IAccount FindCurrentAccount(IAccount account);
        void AddAccount(IAccount account);
        void CheckAcc (IAccount account);
        void UploadAccount(IAccount account);
        void AddGame(IAccount account, string str2, int price);
        public int ReturnIdToAccount();

    }
}
