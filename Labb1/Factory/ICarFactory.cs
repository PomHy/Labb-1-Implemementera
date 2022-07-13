using Labb1.Model;
using Labb1.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1.CarFactory
{
    public abstract class ICarFactory
    {
        protected abstract ICar MakeCar();

        public ICar CreateCar()
        {

            return MakeCar();
        }
    }
}
