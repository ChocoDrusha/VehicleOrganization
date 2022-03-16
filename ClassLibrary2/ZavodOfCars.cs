using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class ZavodOfCars
    {
        public string? Name { get; }

        private ZavodOfCars()
        {

        }

        public ZavodOfCars(string name)
        {
            Name = name;
        }

        public Car CreateCar(string vinNumber, string model, CarType type)
        {
            return new Car(vinNumber, type, model);
        }

        public Motorcycle CreateMotorcycle(string vinNumber, string color, MotorcycleType type)
        {
            return new Motorcycle(vinNumber, type, color);
        }
    }
}
