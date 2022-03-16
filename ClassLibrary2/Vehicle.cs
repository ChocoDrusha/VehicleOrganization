namespace ClassLibrary2
{

    public abstract class Vehicle
    {
        public string VinNumber { get; }
        public string Number { get; }
        
        public Vehicle(string vinNumber)
        {
            if (!VIN.Validate(vinNumber) || !VIN.ControlValidate(vinNumber))
            {
                throw new ArgumentException(nameof(vinNumber));
            }
            VinNumber = vinNumber;

            Number = GIBDD.GenerateNumberCar();
        }

        public override string ToString()
        {
            return $"{VinNumber} {Number}";
        }
    }
}

