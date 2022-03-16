using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class AutoPark
    {
        public Guid Id { get; }
        public string Name { get; }
        public Company Company { get; }
        private List<Car>  _cars = new List<Car>();
        public IEnumerable<Car> Cars => _cars;
        private List<Motorcycle> _motorcycles = new List<Motorcycle>();
        public IEnumerable<Motorcycle> Motorcycles => _motorcycles;
        public IEnumerable<Vehicle> Vehicles => Cars.Select(x => (Vehicle) x).Concat(Motorcycles.Select(x => (Vehicle) x));
        private AutoPark() { }
        internal AutoPark(string name, Company company)
        {
            Id = Guid.NewGuid();
            Name = name;
            Company = company;
        }
        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public void AddMotorcycle(Motorcycle motorcycle)
        {
            _motorcycles.Add(motorcycle);
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
