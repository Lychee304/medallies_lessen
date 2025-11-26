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

            while (running)
            {
                Console.WriteLine(gNumber);
                Console.WriteLine("raad de nummer onder de 1000!");
                int answer = int.Parse(Console.ReadLine());

                
                if(answer > 100)
                {
                    Console.WriteLine("wat zei ik! >:(");
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
