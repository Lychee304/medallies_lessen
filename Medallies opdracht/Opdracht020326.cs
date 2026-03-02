using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Medallies_opdracht
{
    internal class Product
    {
        private float _prijs;

        public float Prijs
        {
            get {
                return _prijs;
            }
            
            set{
                if (value >= 0 && value <= 100)
                {
                    _prijs = value; 
                }
            }
        }

        public Product(float prijs)
        {
            Prijs = prijs;
        }






        /*

        public void Persoon(string naam)
        {
            Naam = naam;
        }

        public string Naam { get; set; }

        public void ZegHallo()
        {
            Console.WriteLine("Hallo, ik ben " + Naam);
        }
        */

    }


}