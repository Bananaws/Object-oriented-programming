using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Strategy.Strategy
{
    internal class Bow : IWeapon
    {

        string IWeapon.Shoot()
        {
            MessageBox.Show("Произведён выстрел из лука");
            return "Bow";
        }
    }
}
