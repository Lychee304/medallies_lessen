using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medallies_opdracht
{
    internal class Opdracht241125
    {
        public int Test = 0;
        private int code = 10;
        private List<string> words = new List<string>()
        {
            "hey",
            "hello",
            "do you want 19 dollar fortnite gift card?",
            "who wants it?",
        };

        private List<int> numbers = new List<int>()
        {
            1,
            69,
            420,
            8,
            5,
        };

        private List<bool> yesNo = new List<bool>()
        {
            true,
            false,
            true,
            false,
         // maybe,
            true
        };

        public void Test2()
        {
            words.Add("i do");
            numbers.Add(4);
            yesNo.RemoveAt(2);

            Console.WriteLine(string.Join(", ", words));
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine(string.Join(", ", yesNo));
        }
    }
}
