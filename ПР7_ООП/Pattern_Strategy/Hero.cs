using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern_Strategy.Strategy;

namespace Pattern_Strategy
{
    internal class Hero
    {
        private readonly string name;
        private IWeapon? weapon;
        private StringBuilder? strbuild;
        public Hero(string name)
        {
            this.name = name;
        }
        public void SetWeapon(IWeapon _weapon)
        {
            weapon = _weapon;
        }
        public StringBuilder Attack()
        {
            strbuild = new StringBuilder();
            if (weapon is null)
            {
                MessageBox.Show("Выберите оружие герою.");
                strbuild.Append("Не было выбрано оружие.");
                return strbuild;
            }
            else
            {
                strbuild.Append($"Герой {name} решил выбрать себе оружие.\n");
                strbuild.Append($"{name} выбрал оружие {weapon.Shoot()}\n");
                strbuild.Append($"После этого {name} ушёл.\n\n");
                return strbuild;
            }
            
        }
    }
}
