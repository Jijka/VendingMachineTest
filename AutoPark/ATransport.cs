namespace AutoPark
{
    public abstract class ATransport : IVehicle, IWheels
    {
        public int Capacity { get; set; }
        public int MaxSpeed { get; set; }
        public string Name { get; set; }

        public abstract int GetNumberOfWheels();
        public int GetNumberOfPassenger() => Capacity;
        public int GetMaxSpeed() => MaxSpeed;
        public string GetName() => Name;
        public double TireSize { get; set; }
        public abstract int NumberOfWheels { get; set; }
    }
}
