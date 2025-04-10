namespace FactoryPattern;

public static class VehicleFactory
{
    public static IVehicle GetVehicle(int numberOfWheels)
    {
        switch (numberOfWheels)
        {
            case 2:
                return new Motorcycle();
            case 4:
                return new Car();
            case > 4:
                return new BigRig();
            default:
                return new Motorcycle();
        }
    }
}