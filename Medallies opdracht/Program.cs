
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medallies_opdracht
{
    internal class Program
    {

        private static string _playerName = "amir";
        static void Main(string[] args)
        {

            Opdracht011225 barb = new Opdracht011225(_playerName, 40, true, 20.3f);

            barb.SayHello();
            barb.TakeDamage(10);
            barb.changeName("man_04");
            Console.WriteLine(barb.getCharacterInfo());


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