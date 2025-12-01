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
        private int _level;
        private int _lives;

        public Opdracht011225(string name, int level, int lives)
        {
            _name = name;
            _level = level;
            _lives = lives;

        }
        
        public string ShowStats()
        {
            return "hi, i am " + _name + ", i have " + _level + " health and " + _lives + " lives!";
        }
    }
}
