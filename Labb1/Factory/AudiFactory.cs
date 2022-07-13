using Labb1.CarFactory;
using Labb1.Model;

using Labb1.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1.FactoryMethod
{

    public class AudiFactory : ICarFactory
    {

        protected override ICar MakeCar()
        {
            ICar car = new AudiCar();
            return car;
        }
    }
}
