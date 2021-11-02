using AppFactoryMethod.Vehicles;

namespace AppFactoryMethod.Factories
{
    class BikeTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Bike();
        }
    }
}
