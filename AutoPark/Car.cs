namespace AutoPark
{
    public class Car : ATransport, ICar
    {
        public Car()
        {
            
        }

        public Car(string classType, string name, int enginePower)
        {
            ClassType = classType;
            Name = name;
            EnginePower = enginePower;
        }

        public string ClassType { get; set; } = "C";

        public override int GetNumberOfWheels() => NumberOfWheels;

        public new string GetName() => $"{Name} класс {ClassType}";
        public override int NumberOfWheels { get; set; } = 4;

        public int EnginePower { get; set; }
    }
}