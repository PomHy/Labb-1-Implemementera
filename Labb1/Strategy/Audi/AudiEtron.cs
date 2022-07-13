using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1.Strategy.Audi
{
    class AudiEtron : IModel
    {
        public string CarModel()
        {
            return "Audi E-tron";
        }
    }
}
