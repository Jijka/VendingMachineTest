namespace AutoPark
{
    public class MotorCycle : Bicycle, IEngine
    {
        
        public int EnginePower { get; set; } = 15;

        public bool SetEngine(IEngine eng)
        {
            EnginePower = eng.EnginePower;
            return EnginePower == eng.EnginePower;
        }

        public bool SetEngine(int enginePower)
        {
            EnginePower = enginePower;
            return EnginePower == enginePower;
        }
    }
}