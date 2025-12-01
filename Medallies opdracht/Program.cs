
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


                Opdracht011225 player = new Opdracht011225(_playerName, 40, 4);
                Console.WriteLine(player.ShowStats());

                Opdracht011225 player2 = new Opdracht011225("a stray cat", 30, 9);
                Console.WriteLine(player2.ShowStats());

                Opdracht011225 player3 = new Opdracht011225("class construction ltd", 420, 69);
                Console.WriteLine(player3.ShowStats());


            List<string, int> playBase = new List<string, int>()
            {
                player,
                player2,
                player3
            };

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
