using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Medallies_opdracht
{
    internal class Opdracht6
    {

        public void Guess()
        {
            Random number = new Random();

            int gNumber = number.Next(0, 1001); // make it adjustable, than gold :D

            int almostU = gNumber - 10;

            int almostA = gNumber + 10;

            bool running = true;

            int enter = 0;

            String welcome = "raad de nummer tussen de 0 en 1000!";

            bool answerA1000 = false;
            bool answerU0 = false;

           

            while (running)
            {
                Console.WriteLine(welcome);
                int answer = int.Parse(Console.ReadLine());

                if(answer > 0 && answer < 1001)
                {
                    enter++;
                }
                
                if(answer > 1000)
                {
                    answerA1000 = true;
                    running = false;
                    answerU0 = false;
                }

                if(answer < 0)
                {
                    answerU0 = true;
                    running = false;
                    answerA1000 = false;
                }

                if (answer == gNumber)
                {
                    running = false;
                } else if (answer > almostU && answer < gNumber)
                {
                    Console.WriteLine("ietsjes meer!");
                }
                else if (answer < almostA && answer > gNumber)
                {
                    Console.WriteLine("ietsjes minder!");
                }


            }
            Console.WriteLine(" ");
            Console.WriteLine("De geheime nummer was: " + gNumber + ", het kostte je " + enter + " pogingen!");

            if(answerA1000 != false)
            {
                Console.WriteLine("helaas win je niet omdat je meer dan 1000 heb ingevoerd :(");
                
            }
            
            if(answerU0 != false)
            {
                Console.WriteLine("was ik niet duidelijk? je mocht niet onder de 0, je hebt niet gewonnen  :(");
                answerA1000 = false;
            }

        }

    }
}
