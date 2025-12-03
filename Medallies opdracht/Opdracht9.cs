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

        public Opdracht9(string name, int damage)
        {
            _name = name;
            _damage = damage;

            Console.WriteLine("your weapon is ready sir!");
        }

        public void showStats()
        {
            Console.WriteLine("your "+ _name + " can do " + _damage+ " damage, thats cool!");
        }
    }
}
