using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_3
{
    internal class Account
    {
        private double balance = 0;

        // события
        public event EventHandler<double>? AddedEvent;
        public event EventHandler<double>? TakenEvent;


        public void Add(double sum) // добавляет сумму к балансу
        {
            balance += sum;
            AddedEvent?.Invoke(this, balance); // вызываем все методы, подписанные на событие
        }
        public void Take(double sum) // списывает сумму с баланса
        {
            if (sum > balance)
            {
                MessageBox.Show("Недостаточно средств для списания. Пополните счёт.");
                return;
            }
            balance -= sum;
            TakenEvent?.Invoke(this, balance); // вызываем все методы, подписанные на событие

        }
    }
}
