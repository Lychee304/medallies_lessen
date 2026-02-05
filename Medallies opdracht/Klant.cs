using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medallies_opdracht
{
    internal class Klant
    {
        private int _id;
        private string _name;
        private string _email;
        private string _password;
        private string _birth;

        public void KlantInfo(int id, string name, string email, string password, string birth)
        {
            _id = id;
            _name = name;
            _email = email;
            _password = password;
            _birth = birth;
        }

        public String PrintKlantInfo()
        {
            return "klant id: " + _id + ", name: " + _name + ", email of klant: " + _email + ", password of klant: " + _password + ", birthdate of klant: " + _birth;
        }
    }
}



/* example from opdracht 9
 
        public void showStats()
        {
            Console.WriteLine("your " + _name + " can do " + _damage + " damage, thats cool!");
        }

        public void UpgradeItem()
        {
            _damage += _damageToAdd;
            Console.WriteLine("Your " + _name + " gets a damage buff of " + _damageToAdd + ", which is for free, it can now do a damage of " + _damage + "!");
            Console.WriteLine(" ");
        }
    }
}

*/