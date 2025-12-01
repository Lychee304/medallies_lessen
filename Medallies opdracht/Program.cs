using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medallies_opdracht
{
    internal class Program
    {

        private static string _fName = "amir";
        private static string _lName = "allouti";
        private static int _age = 19;

        static void Main(string[] args)
        {

            Opdracht011225 student = new Opdracht011225(_fName, _lName, _age);
            Opdracht011225 student2 = new Opdracht011225("first", "last", 69);

            /*
            Opdracht011225 opdracht = new Opdracht011225();
            opdracht.Class();
            
            
            Console.WriteLine("Hoe heet je?");
            string input = Console.ReadLine();
            Console.WriteLine("en hoe oud ben je?");
            string input1 = Console.ReadLine();
            Console.WriteLine("Hoi " + input + ", je bent " + input1 + " jaar oud!");
            */
        }
        }
    }
