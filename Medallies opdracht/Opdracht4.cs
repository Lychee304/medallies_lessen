using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medallies_opdracht
{
    internal class Opdracht4
    {

        public void AgeCal()
        {
            Console.WriteLine("hey, welk jaar ben je geboren?");
            int input = int.Parse(Console.ReadLine());

            int age = 2025 - input;
            if (age >= 18 && age <= 30)
            {
                Console.WriteLine("je bent " + age + " jaar oud, je mag stemmen!");
            }
            else if (age >= 31 && age <= 70)
            {
                Console.WriteLine("je bent " + age + " jaar oud, tuurlijk mag u stemmen!");
            }
            else if (age > 70)
            {
                Console.WriteLine("je bent " + age + " jaar oud, heeft u de stemmen uitgevonden?");
            }
            else if(age < 18 && age >= 0)
            {
                Console.WriteLine("je bent " + age + " jaar oud, je moet 18 jaar of ouder zijn!");
            }
            else if(age < 0)
            {
                Console.WriteLine("je bent " + age + " jaar oud, hoe?");
            }
        }
    }
}
