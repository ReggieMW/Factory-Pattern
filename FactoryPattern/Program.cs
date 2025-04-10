namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels does your vehicle have?");
            int wheels = int.Parse(Console.ReadLine());
            IVehicle vehicle = VehicleFactory.GetVehicle(wheels);
            vehicle.Drive();
        }
    }
}
