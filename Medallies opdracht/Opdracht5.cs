using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medallies_opdracht
{
    internal class Opdracht5
    {
        public void TableForFor()
        {
            Console.WriteLine("vul het eerste nummer in");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("vul het tweede nummer in");
            int input1 = int.Parse(Console.ReadLine());

            int answer = input * input1;

            for (int i = input; i < input1; i++)
            {
                Console.WriteLine(input + " X " + input1 + " = " + input * input1);
            }
        }
    }
}
