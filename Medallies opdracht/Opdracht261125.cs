using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Medallies_opdracht
{
    internal class Opdracht261125
    {
        public void LoopDiLoops()
        {

            // Do While loops

            int numberDW = 0;

            do
            {
                numberDW += 1;
                Console.WriteLine("Do While loop: " + numberDW);
            } while (numberDW < 10);



            // For loops

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("For loop: " + i);
            }




            // For Each loops
            int numberEL = 0;

            int[] y = new int[10];
            foreach (int number in y)
            {
                numberEL += 1;
                Console.WriteLine("For Each loop: " + numberEL);
            }



            // While loops

            int numberW = 0;

            while (numberW < 10)
            {

                numberW += 1;
                Console.WriteLine("While loop: " + numberW);
            }
        }
    }
}
