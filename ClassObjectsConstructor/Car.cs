using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectsConstructor
{
    internal class Car
    {
        public string Brend { get;  }
        public string Model { get; }
        public int Il { get; }
        public string FuelType { get; }
        public string Reng { get; }

        public Car(string brend, string model, int il, string fueltype, string reng)
        {
            Brend = brend;
            Model = model;
            Il = il;
            FuelType = fueltype;
            Reng = reng;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Brend = {Brend}, Model = {Model}, Il = {Il}, FuelType = {FuelType}, Il = {Il}, Reng = {Reng}");
        }
    }
}
