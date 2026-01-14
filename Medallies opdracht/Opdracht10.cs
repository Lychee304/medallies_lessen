using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medallies_opdracht
{
    internal class Opdracht10
    {

        String answer = "";

        public void Palindrome()
        {

            Console.WriteLine("vul hier in ni reih luv");
            String input = " " + Console.ReadLine();

            char[] paliCharArray = input.ToCharArray();

            for (int i = paliCharArray.Length - 1; i > 0; i--)
            {
                answer = Console.Write(paliCharArray[i]);

                if(answer == input) {
                    Console.WriteLine("hi :)");
                }
            }
        }
    }
}
