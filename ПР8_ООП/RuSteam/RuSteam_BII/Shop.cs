using RuSteam_DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RuSteam_BII
{
    public class Shop: IShop
    {
        
        public event AccountHandler? Notify;

        private readonly IGameData<IGame> gameData;
        private IAccountData<IAccount> accData;
        public Shop(IGameData<IGame> _gameData, IAccountData<IAccount> _accData)
        {
            gameData = _gameData ??
                throw new ArgumentNullException(nameof(_gameData));
            accData = _accData ??
                throw new ArgumentNullException(nameof(_accData));

        }
        public static string? str { get; set; }
        public IEnumerable<IGame> GetAllGames()
        {
            return gameData.UpdateGameList();
        }

        public IEnumerable<IGame> FindGames(string input)
        {
            return gameData.FindGames(input);
        }
        public IAccount FindCurrentAccount(IAccount account)
        {
            return accData.FindAccount(account);
        }
        public void AddAccount(IAccount account)
        {
            CheckAcc(account);
        }
        public void UploadAccount(IAccount account)
        {
            
            accData.UploadAccount(account);
        }
        public void CheckAcc(IAccount account)
        {
            str = accData.CheckAcc(account);
            if (str != null) Notify?.Invoke(this, new AccountEventArgs($"{str}"));
            else { Notify?.Invoke(this, new AccountEventArgs($"Аккаунт успешно создан")); accData.AddAccount(account); }
            }
        public int ReturnIdToAccount()
        {
            return accData.GiveIdToAccount();
        }
        public void AddGame(IAccount account, string str, int price)
        {
            accData.AddGame(account, str, price);
        }
    }
}
