using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Motorcycle : Vehicle
    {
        internal Motorcycle(string vinNumber, MotorcycleType type, string color) : base(vinNumber)
        {
            Type = type;
            Color = color;
        }
        public MotorcycleType Type { get; }
        public string Color { get; }

        public override string ToString()
        {
            return $"{Color} {Type} {VinNumber} {Number}";
        }
    }
}
