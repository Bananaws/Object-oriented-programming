using RuSteam_DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuSteam_Data_Sql
{
    public class AccountDataSql : IAccountData<IAccount>
    {
        public void AddGame(IAccount account, string str, int price)
        {
            using (var database = new RuSteamContext())
            {
                var currentAccount = new AccountEntity(account);
                foreach(var acc in database.Accounts)
                {
                    if (acc.Id == account.Id)
                    {
                        acc.Money -= price;
                        if (acc.Games == "None")
                        {
                            acc.Games = str;
                        }
                        else
                        {
                            acc.Games += $";{str}";
                        }
                        database.SaveChanges();
                    }
                }
            }
        }
        public void AddAccount(IAccount acc)
        {
            using (var database = new RuSteamContext())
            {
                var currentAccount = new AccountEntity(acc);
                currentAccount.Id = database.Accounts.Count() + 1;
                currentAccount.Games = "None";
                database.Accounts.Add(currentAccount);
                database.SaveChanges();
            }
        }
        public string? CheckAcc(IAccount acc)
        {
            using (var database = new RuSteamContext())
            {
                var currentAccount = new AccountEntity(acc);
                foreach (var account in database.Accounts)
                {
                    if (account.Nick_name == acc.Nick_name)
                    {
                        string str = $"Аккаунт {account.Nick_name} уже существует.";
                        return str;
                    }
                }
                return null;
            }
        }
        public void UploadAccount(IAccount acc)
        {
            using (var database = new RuSteamContext())
            {
                foreach(var a in database.Accounts)
                {
                    if (a.Id == acc.Id)
                    {
                        a.Money = acc.Money;
                    }
                }
                database.SaveChanges();
            }
        }
        
        public int GiveIdToAccount()
        {
            using (var database = new RuSteamContext())
            {
                int id = database.Accounts.Count() + 1;
                return id;
            }
        }

        public IAccount FindAccount(IAccount acc)
        {
            using (var database = new RuSteamContext())
            {
                IAccount currentUser = database.Accounts.SingleOrDefault(unknownAcc => unknownAcc.Nick_name.Equals(acc.Nick_name)
                    && unknownAcc.Password.Equals(acc.Password));
                return currentUser;
            }
        }


        public void AddGameToAccountLibrary(IAccount acc, IGame game)
        {
            throw new NotImplementedException();
        }
    }
}
