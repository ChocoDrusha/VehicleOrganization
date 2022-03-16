using ClassLibrary2;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var zavod = new ZavodOfCars("Машинный завод");
            var car1 = zavod.CreateCar("1HGBH41JXMN109186", "Тесла", CarType.Hatchback);
            var motorcycle1 = zavod.CreateMotorcycle("1HGBH41JXMN109186", "White", MotorcycleType.Sport);
            Console.WriteLine(car1.ToString());
            Console.WriteLine(motorcycle1.ToString());
            var company = new Company("sadsad");
            var park = company.CreateAutoPark("papa");
            //var company = new Company("sadsad");
            var park2 = company.CreateAutoPark("mama");
            Console.WriteLine(park2.Company.Name);
            Console.WriteLine(company.AutoParks.First().ToString());
            Console.WriteLine(park2.Id);
            Console.WriteLine(park.Id);
            park.AddCar(car1);
            park.AddMotorcycle(motorcycle1);
            foreach(var vehicle in park.Vehicles)
            {
                Console.WriteLine(vehicle.ToString());
            }


        }
    }
}