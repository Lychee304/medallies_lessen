using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medallies_opdracht
{
    internal class Opdracht2
    {
        public void Opdracht()
        {
            Opdracht2 test = new Opdracht2();

            Console.WriteLine("Kies een kant, links of rechts? stil staan is geen optie (voer L in voor links en R voor rechts, voer A in als een 3de optie mogelijk is)");
            string input = Console.ReadLine();

            if(input == "L")
            {

                Console.WriteLine("je bent links gegaan, je zit in de woonkamer, en nu?");
                string inputL = Console.ReadLine();

                if(inputL == "L")
                {
                    Console.WriteLine("je bent links naar buiten gegaan, je staat buiten, ga je links, rechts of rechtdoor?");
                    string inputL2 = Console.ReadLine();

                    if(inputL2 == "L")
                    {
                        Console.WriteLine("je staat bij de voordeur, toevallig zit er een monster die wou inbreken, hij eet je, je hebt verloren!");
                    }
                }

            } else if(input == "R")
            {
                Console.WriteLine("er zit een trap, als je deze bent op gegaan kan je links en rechts");
            }
            
            /*
            if (input == "links")
            {
                Console.WriteLine("je bent de linker kamer in gegaan, je bevind je in de woonkamer, waar ga je nu heen, links of rechts?");
                string inputA = Console.ReadLine();

            }
            if inputA == "links"{
                Console.WriteLine("je bevind je in de keuken, er is een magische koelkast links van je, rechts heb je n deur, ga je links of ga je naar rechts?");
                string inputA1 = Console.ReadLine();

            }
            if inputA1 == "links"{
                Console.WriteLine("er zat n monster in de koelkast? dat stond er op n kaartje, aangezien het warm was had je dorst, het was geen blikje maar een echte monster, je hebt verloren!");
            }


            else if inputA1 == "rechts"{
                Console.WriteLine("de deur ging naar buiten, je hebt gewonnen! Waarom sta je buiten eigenlijk?");
            }
            else if inputA == "rechts"{
                console.WriteLine("rechts van je stond n Nintendo Wii met mario kart, je speelde tegen n bot, toen je n blue shell gooide hoorde je een gebrul naast van je. Wat bleek? het was geen bot maar een monster, uit rage at hij je op. Je hebt verloren! alleen niet in mario kart, je kwam 1ste!");

            }
            else if input == "rechts"{
                console.WriteLine("je bent de trap op gegaan, je bevind je in de hal, je hebt 2 deuren en je moet kiezen, links of rechts?");
                string inputB1 == Console.ReadLine();
            }
            if inputB1 == "links"{
                Console.WriteLine("je staat nu in de badkamer, je hoort iets de trap opgaan, links van je heb je een kleine raam waar je kan ontsnappen, rechts van je heb je n badkuip en een gordijn waar je kan verstoppen, wat kies je?");
                string inputB2 = Console.ReadLine();
            }
            if inputB2 == "rechts"{
                Console.WriteLine("je hoort het wezen binnenkomen, hij wou een bad nemen (van alles wat hij kon doen) en hij ziet jou, je wordt geteleporteerd naar de backrooms, je hebt verloren");
            }
            else if inputB2 == "links"{
                Console.WriteLine("je bent door het raampje geklomen en bevind je op t dak, helaas stond er iemand van de Arbeidsinspectie en heeft je meteen meegenomen omdat je niet de correcte werkkleding aan had, je hebt verloren");
            }
            else
            {
                Console.WriteLine("je bleef stilstaan, het wezen kwam naar binnen, gelukkig was het een T-Rex en zag hij jou niet omdat je stil bleef staan. Op het moment dat hij wegkeek rende je weg naar buiten, je hebt gewonnen! Al vraag je je af hoe een T-Rex in een huis past");
            }

    else if inputB1 == "rechts"{
                Console.WriteLine("je bevind je zich in de slaapkamer, in deze slaapkamer stonden 3 bedden, het 1st bed was veel te hard, het 2de bed was veel te zacht, en de 3de bed was een monster, die jou at. Je hebt verloren!");
            }
            else
            {
                Console.WriteLine("er viel een monster op je, je hebt verloren!");
            }

            */
            
        }
    }
}

