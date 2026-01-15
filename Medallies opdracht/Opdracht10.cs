using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Medallies_opdracht
{
    internal class Opdracht10
    {


        public void Palindrome()
        {

            Console.WriteLine("vul hier in ni reih luv");
            String input = " " + Console.ReadLine();

            String answer = "";

            String answerL = answer.ToLower();

            char[] paliCharArray = input.ToCharArray();

            for (int i = paliCharArray.Length - 1; i > 0; i--)
            {


                answer = Char.ToString(paliCharArray[i]);

                answerL = answer;

                Console.Write(answerL);
            }

            if (" " + answerL == input + " ")
            {
                Console.WriteLine(" ");
                Console.WriteLine("het is een palindroom!");
            }
        }
    }
}
