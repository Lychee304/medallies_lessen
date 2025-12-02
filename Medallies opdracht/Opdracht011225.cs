using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Medallies_opdracht
{
    internal class Opdracht011225
    {
        private string _name;
        private int _health;

        public Opdracht011225(string name, int hp, bool spawned, float speed)
        {
            _name = name;
            _health = hp;
            Console.WriteLine("hoi " + _name + ", welcome bro :)");

        }

        public void SayHello()
        {
            Console.WriteLine("nice to meet you");
        }

        public void TakeDamage(int damageAmount)
        {
            Console.WriteLine("oh damn i lost " + damageAmount);
            _health -= damageAmount;
            Console.WriteLine("i have this amount of hp left: " + _health);
        }

        public void changeName(string newName)
        {
            _name = newName;
            Console.WriteLine("My new name is: " + _name);
        }

        public string getCharacterInfo()
        {
            return "hi, i am " + _name + ", i have " + _health + " health left";
        }
    }
}
