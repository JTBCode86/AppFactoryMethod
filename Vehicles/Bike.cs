using System;

namespace AppFactoryMethod.Vehicles
{
    class Bike : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Já pegamos a comida!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando o delivery.");
        }
    }
}
