using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuSteam_DIAGRAMS
{
    public interface IAccountData<T>
    {
        void AddAccount(T acc);
        void AddGame(T acc,string str, int price);
        string? CheckAcc(T acc);
        void UploadAccount(T account);
        IAccount FindAccount(T acc);
        int GiveIdToAccount();
    }
}
