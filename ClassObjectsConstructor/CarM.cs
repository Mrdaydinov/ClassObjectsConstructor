using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectsConstructor
{
    internal class CarM
    {
        public string Model { get; }
        public string Brend { get; }
        public int Year { get;  }
        public int MaxSpeed { get; }
        public int NumSeats { get; }

        public CarM(string model, string brend, int year, int maxSpeed, int numSeats)
        {
            Model = model;
            Brend = brend;
            Year = year;
            MaxSpeed = maxSpeed;
            NumSeats = numSeats;

            if (MaxSpeed > 110)
                Console.WriteLine("Suret oldurur");
            else
                Console.WriteLine("Bele davam edin");
        }
    }
}
