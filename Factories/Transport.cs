using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFactoryMethod.Vehicles;

namespace AppFactoryMethod.Factories
{
    abstract  class Transport
    {
        public void StartTransport() 
        {
            IVehicle vihicle = CreateTransport();
            vihicle.StartRoute();
        }

        protected abstract IVehicle CreateTransport();

    }
}
