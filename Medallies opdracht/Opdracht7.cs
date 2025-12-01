using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medallies_opdracht
{
    internal class Opdracht7
    {
        public void Cube()
        {
            Random number = new Random();

            int number1 = 0;
            int number2 = 0;
            int number3 = 0;
            int number4 = 0;
            int number5 = 0;
            int number6 = 0;


            for (int i = 0;i < 100; i++)
            {
                int gNumber = number.Next(1, 7);
                Console.WriteLine(gNumber);

                

                if (gNumber == 1)
                {
                    number1++;
                } 
                else if (gNumber == 2)
                {
                    number2++;
                }
                else if (gNumber == 3)
                {
                    number3++;
                }
                else if (gNumber == 4)
                {
                    number4++;
                }
                else if (gNumber == 5)
                {
                    number5++;
                }
                else if (gNumber == 6)
                {
                    number6++;
                }
            }

            Console.WriteLine(" ");

            Console.WriteLine("1 kwam voor: " + number1);
            Console.WriteLine("2 kwam voor: " + number2);
            Console.WriteLine("3 kwam voor: " + number3);
            Console.WriteLine("4 kwam voor: " + number4);
            Console.WriteLine("5 kwam voor: " + number5);
            Console.WriteLine("6 kwam voor: " + number6);
        }
    }
}
