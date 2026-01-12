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

            Console.WriteLine("Kies een kant, links of rechts? stil staan is geen optie (voer L in voor links en R voor rechts, voer A in als een 3de optie mogelijk is, en A1 voor een 4de optie (nee dat is niet nu, of wel?))");
            string input = Console.ReadLine();

            if (input == "L")
            {

                Console.WriteLine("je bent links gegaan, je zit in de woonkamer, en nu? links, rechts of wii spelen (A)?");
                string inputL = Console.ReadLine();


                if (inputL == "L")
                {
                    Console.WriteLine("je bent links naar buiten gegaan, je staat buiten, ga je links, rechts of rechtdoor?");
                    string inputL2 = Console.ReadLine();


                    if (inputL2 == "L")
                    {
                        Console.WriteLine("je staat bij de voordeur, toevallig zit er een monster die wou inbreken, hij eet je, je hebt verloren!");
                        // end of line
                    }
                    else if (inputL2 == "R")
                    {
                        Console.WriteLine("je staat bij de buren, achter zie je n monster die wou inbreken, ren je de weg (L) op of bij de buren (R) naar binnen?");
                        string inputL2R = Console.ReadLine();

                        if (inputL2R == "R")
                        {
                            Console.WriteLine("je rent bij je buren naar binnen, hij had een berenval bij de deur, je hebt verloren! (waarom had hij er een?)");
                        }
                        else if (inputL2R == "L")
                        {
                            Console.WriteLine("je rent de weg op, de monster volgt je niet eens, hij brook in en steelde jou voordeur, je hebt verloren! (het was geen inbreken als hij alleen jou deur steelde, of wel?)");
                        }
                    }
                    else if (inputL2 == "A")
                    {
                        Console.WriteLine("je blijft lopen tot je bij de ikea komt, ze hebben gratis veggiedogs, je hebt gewonnen!");
                    }

                } else if (inputL == "R")
                {
                    Console.WriteLine("je loopt naar de keuken en je ziet 1 hotdog op tafel, eet je m (L) of niet (R)?");
                    string inputLR = Console.ReadLine();

                    if(inputLR == "R")
                    {
                        Console.WriteLine("je eet m niet, nu wat (L), (R), (A) of (A1)?");
                        string inputLR2 = Console.ReadLine();

                        if (inputLR2 == "L")
                        {
                            Console.WriteLine("je opent n cheat menu en je ge-   je hebt verloren! (ban: 10 days | reason: cheating)");
                        } else if(inputLR2 == "R")
                        {
                            Console.WriteLine("L, R, L, R, je houdt van zigzag of nie? de monster nie en hij valt flauw, je hebt gewonnen!");
                        } else if(inputLR2 == "A")
                        {
                            Console.WriteLine("je confronteert de monster, hij eet alleen voordeuren en kan geen voordeur betalen, je besloot hem geld te geven, BUT IT WAS THE SPANISH INQUSITION, die verwachte je nie he? anyway je hebt gewonnen!");
                        } else if(inputLR2 == "A1")
                        {
                            Console.WriteLine("je blijft daar staan, de monster staat naast je, jullie staren naar de hotdog voor 3 uur, uiteindelij- je hebt verloren! (kicked | reason: afk)");
                        }


                    } else if(inputLR == "L")
                    {
                        Console.WriteLine("doe je er saus op (L) of nie (R)?");
                        string inputL2R = Console.ReadLine();

                        if(inputL2R == "L")
                        {
                            Console.WriteLine("je eet m op met hotdog saus, gratis hotdog, je hebt gewonnen! dat dacht je he? de saus was vergiftigd en je hebt verloren!");
                        } else if (inputL2R == "R")
                        {
                            Console.WriteLine("je eet m droog op, gratis hotdog, je hebt gewonnen!");
                        }

                    }
                } else if (inputL == "A")
                {
                    Console.WriteLine("voor je stond n Nintendo Wii met mario kart, je speelde tegen n bot, toen je n blue shell gooide hoorde je een gebrul naast van je. Wat bleek? het was geen bot maar een monster, uit rage at hij je op. Je hebt verloren! alleen niet in mario kart, je kwam 1ste!");
                }
            }
            else if (input == "R")
            {
                Console.WriteLine("er zit een trap, als je deze bent op gegaan kan je links, rechts of de magische portaal binnentreden");
                string inputR = Console.ReadLine();

                if (inputR == "L")
                {
                    Console.WriteLine("je loopt de linker kamer in, het is de badkamer, je kan 4 dingen doen, links van je heb je n deur, voor je heb je n bad met bubbel functie (A), rechts van je heb je een spiegelkastje waar je perfect in past en onder je heb je n amogus mat die een poort verbergt (A1). wat doe je?");
                    string inputR2L = Console.ReadLine();

                    if (inputR2L == "R")
                    {
                        Console.WriteLine("je verstopt je in de spiegelkastje, je vroeg je af waarom je eigenlijk verstopt zat, toen je weer eruit kwam, kwam er een monster die je at, je hebt verloren!");
                    }
                    else if (inputR2L == "L")
                    {
                        Console.WriteLine("je doet de deur open, je hebt een iliegale gokclub gevonden, je doet mee en verliest alles, je hebt verloren! (dacht je dat je ging winnen?)");
                    }
                    else if (inputR2L == "A")
                    {
                        Console.WriteLine("je gaat in het bad en relaxt, de monster wou je eten maar wacht tot je eruit komt, hij heeft geen geduld en gaat naar de buren, je hebt gewonnen! (denk je dat de monster het voorbij de voordeur maakt?)");
                    }
                    else if (inputR2L == "A1")
                    {
                        Console.WriteLine("je haalt de amogus mat van de grond en houdt m voor jezelf, je treed de poort binnen en teleporteert je naar de voordeur, alleen is de voordeur gestolen door een monster die je gelijk at, je hebt verloren!");
                    }
                } else if(inputR == "R")
                {
                    Console.WriteLine("je bent de rechter kamer binnengegaan, je kan via het raam (L) naar buiten, of je neemt n dutje (R), wat doe je?");
                    string inputR2 = Console.ReadLine();

                    if(inputR2 == "R")
                    {
                        Console.WriteLine("je kan niet slapen, je kiest om een video te kijken voor het slapen, kies je n rustgevende video (L) of een horrorfilm (R)?");
                        string inputR3 = Console.ReadLine();

                        if(inputR3 == "R")
                        {
                            Console.WriteLine("je kijkt een horrorfilm en gaat slapen, door een nachtmerrieschepsel in je nachtmerrie (duh) schrik je wakker en zie je een monster voor je neus, je dacht dat het een nachtmerrie was en sloeg hem, hij at je, je hebt verloren!");
                        } else if(inputR3 == "L")
                        {
                            Console.WriteLine("je viel meteen in slaap en niks anders gebeurde, toen je wakker werdt zag je een witte monster naast je, alleen is dit een monster die je drinkt, je hebt gewonnen! tenzij je monster niet lekker vind ig");
                        }
                    }
                } else if(inputR == "A")
                {
                    Console.WriteLine("je treed de magische portaal binnen, als je in de andere dimensie zit, kom je erachter dat dit de nether portal was, je hebt geen golden armor en er staan 20 piglins naar je te kijken, je hebt verloren!");
                }
            } else if(input == "A")
            {
                Console.WriteLine("je hebt gewonnen! (huh?)");
            } else if(input == "A1")
            {
                Console.WriteLine("je deed een zieke achtersalto, samen met publiek en 2x score multiplier, alleen heb je verloren! (de monster at je en steelde trouwens je voordeur)");
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


