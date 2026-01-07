using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medallies_opdracht
{
    internal class Car
    {
        private String _name;
        private String _brand;
        private int _amountOfDoors;


        public Car(String name, String brand, int amountOfDoors)
        {
            _name = name;
            _brand = brand;
            _amountOfDoors = amountOfDoors;
        }

        public void PrintCarInfo()
        {
            Console.WriteLine($"auto naam: {_name} en merk: {_brand}");
        }
    }
}
