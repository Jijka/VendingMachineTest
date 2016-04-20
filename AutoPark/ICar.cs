namespace AutoPark
{
    public interface ICar: IWheels, IEngine
    {
        string ClassType { get; set; }
    }
}