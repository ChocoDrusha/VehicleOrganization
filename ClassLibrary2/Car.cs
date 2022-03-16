using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Car : Vehicle
    {
        internal Car(string vinNumber, CarType type, string model) : base(vinNumber)
        {
            Model = model;
            Type = type;
        }
        public string Model { get; }
        public CarType Type { get; }

        public override string ToString()
        {
            return $"{Model} {Type} {VinNumber} {Number}";
        }
    }
}
