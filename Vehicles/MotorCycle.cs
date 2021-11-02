using System;

namespace AppFactoryMethod.Vehicles
{
    class MotorCycle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda!!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciamos a entrega da encomenda.");
        }
    }
}
