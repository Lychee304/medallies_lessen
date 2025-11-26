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

            for(int i = 1;i < input1 + 1; i++)
            {
                Console.WriteLine(input + " X " + i + " = " + input * i);
            }
        }
    }
}
