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
        private string _fName;
        private string _lName;
        private int _age;

        public Opdracht011225(string fName, string lName, int age)
        {
            _fName = fName;
            _lName = lName;
            _age = age;
            Console.WriteLine("hoi " + fName + " " + lName + ", your " + age + " years old, welcome bro :)");

        }

        
    }
}
