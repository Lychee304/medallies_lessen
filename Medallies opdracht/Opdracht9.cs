using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Medallies_opdracht
{
    internal class Opdracht9
    {
        private string _name;
        private int _damage;
        private int _damageToAdd = 10;

        public Opdracht9(string name, int damage)
        {
            _name = name;
            _damage = damage;

        }

        public void showStats()
        {
            Console.WriteLine("your "+ _name + " can do " + _damage+ " damage, thats cool!");
        }

        public void UpgradeItem()
        {
            _damage += _damageToAdd;
            Console.WriteLine("Your " + _name + " gets a damage buff of " + _damageToAdd + ", which is for free, it can now do a damage of " + _damage + "!");
            Console.WriteLine(" ");
        }
    }
}
