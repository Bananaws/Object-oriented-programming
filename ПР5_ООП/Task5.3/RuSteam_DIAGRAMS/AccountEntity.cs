using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RuSteam_DIAGRAMS
{
    public class AccountEntity: IAccount
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
        public AccountEntity() { }
        public AccountEntity(IAccount acc)
        {
            Id = 0;
            Nick_name = acc.Nick_name;
            Password = acc.Password;
            Money = acc.Money;
            Games = acc.Games;
        }
    }
}
