namespace AutoPark
{
    public class Bicycle : ATransport
    {
        public override int GetNumberOfWheels() => NumberOfWheels;

        public override int NumberOfWheels { get; set; } = 2;
    }
}