using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medallies_opdracht
{
    internal class Opdracht3
    {

        public void WeatherAdvice()
        {
            Console.WriteLine("wat is het weer? zonnig, regen of bewolkt?");
            string input = Console.ReadLine();

            if (input == "zonnig")
            {
                Console.WriteLine("hoeveel graden is het?");
                int input1 = int.Parse(Console.ReadLine());

                if (input1 <= 0)
                {
                    Console.WriteLine("blijf thuis en zet de verwarming aan!");
                } else if (input1 > 0 && input1 < 10)
                {
                    Console.WriteLine("trek een jas aan, en een sjaal!");
                }
                else if (input1 >= 10 && input1 < 20)
                {
                    Console.WriteLine("trek een jas aan!");
                }
                else if (input1 >= 20 && input1 < 30)
                {
                    Console.WriteLine("trek een vest aan!");
                }
                else if (input1 >= 30 && input1 < 40)
                {
                    Console.WriteLine("vergeet je zonnebril niet!");
                }
                else if (input1 >= 40 && input1 < 50)
                {
                    Console.WriteLine("vergeet je zonnebrand creme en fles water niet!");
                }
                else if (input1 >= 50)
                {
                    Console.WriteLine("zoek een airconditioned ruimte, je hebt t nodig!");
                }
            } else if(input == "bewolkt")
            {
                Console.WriteLine("Dit is de beste weer, je hebt gewonnen");
            } else if(input == "regen")
            {
                Console.WriteLine("Neem je paraplu mee!");
            }
            {
                Console.WriteLine("nee dit kennen we nie!");
            }
        }
    }
}
