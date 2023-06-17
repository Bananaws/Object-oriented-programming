using RuSteam_DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuSteam_BII
{
    public class Account : IAccount
    {
        public int Id { get; set; }
        public string Nick_name { get; set; }
        public string Password { get; set; }
        public int Money { get; set; }
        public string Games { get; set; }
        public void Deposit(int num)
        {
            Money += num;
        }
    }
}
