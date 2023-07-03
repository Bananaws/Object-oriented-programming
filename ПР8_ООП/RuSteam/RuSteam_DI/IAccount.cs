using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuSteam_DI
{
    public interface IAccount
    {
        int Id { get; set; }
        string Nick_name { get; set; }
        string Password { get; set; }
        public int Money { get; set; }
        string Games { get; set; }
        void Deposit(int num);
    }
}
