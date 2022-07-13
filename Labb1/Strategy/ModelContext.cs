using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1.Strategy
{
    class ModelContext
    {
        private IModel Model;


        public ModelContext(IModel model)
        {
            Model = model;
        }

        public string CreateCarModel()
        {
            return Model.CarModel();

        }
      

    }
}
