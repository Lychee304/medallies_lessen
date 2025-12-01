using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medallies_opdracht
{
    internal class Opdracht6
    {

        public void Guess()
        {
            Random number = new Random();

            int gNumber = number.Next(1, 1001);

            int almostU = gNumber - 10;

            int almostA = gNumber + 10;

            bool running = true;

            String welcome = "raad de nummer onder de 1000!";

            while (running)
            {
                Console.WriteLine(gNumber);
                Console.WriteLine(welcome);
                int answer = int.Parse(Console.ReadLine());

                
                if(answer > 1000)
                {
                    Console.WriteLine("wat zei ik! >:(");
                }

                if(answer < 0)
                {
                    Console.WriteLine("we got a smart one here huh?");
                }

                if (answer == gNumber)
                {
                    running = false;
                    Console.WriteLine("De geheime nummer was: " + gNumber + "!");
                } else if (answer > almostU && answer < gNumber)
                {
                    Console.WriteLine("ietsjes meer!");
                }
                else if (answer < almostA && answer > gNumber)
                {
                    Console.WriteLine("ietsjes minder!");
                }


                Console.Clear();
            }

        }

    }
}
