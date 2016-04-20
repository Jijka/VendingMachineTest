namespace AutoPark
{
    public class Engine : IEngine
    {
        public Engine()
        {
            
        }
        public Engine(int enginePower)
        {
            EnginePower = enginePower;
        }
        public int EnginePower { get; set; } = 50;

    }
}