using Labb1.CarFactory;
using Labb1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1.FactoryMethod
{
    public class TeslaFactory : ICarFactory
    {
        protected override ICar MakeCar()
        {
            ICar car = new TeslaCar();
            return car;
        }

    }
}
