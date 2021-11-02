using AppFactoryMethod.Vehicles;

namespace AppFactoryMethod.Factories
{
    class MotorCycleTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new MotorCycle();
        }
    }
}
