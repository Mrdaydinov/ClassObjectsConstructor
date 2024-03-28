using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectsConstructor
{
    internal class Motorcycle
    {
        public string Model { get; }
        public string Brend { get; }
        public int Year { get; }
        public int MaxSpeed { get; }
        public bool HasSidecar { get; }

        public Motorcycle(string model, string brend, int year, int maxSpeed, bool hasSidecar)
        {
            Model = model;
            Brend = brend;
            Year = year;
            MaxSpeed = maxSpeed;
            HasSidecar = hasSidecar;

            if (MaxSpeed > 110)
                Console.WriteLine("Suret oldurur");
            else
                Console.WriteLine("Bele davam edin");
        }
    }
}
