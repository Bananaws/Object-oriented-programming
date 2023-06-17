using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_3
{ // Класс Активность хранит добавленное, взятое и баланс. Обновляет их метод UpdateActivity
    internal class Activity
    {
        public double added = 0;
        public double taken = 0;
        private double balance = 0;

        public void UpdateActivity(object? obj, double dep)
        {
            if (balance < dep) added += dep - balance;
            else taken += balance - dep;
            balance = dep;
        }
    }
}
