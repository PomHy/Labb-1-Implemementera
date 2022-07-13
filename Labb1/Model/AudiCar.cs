using Labb1.Strategy;
using Labb1.Strategy.Audi;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1.Model
{
    class AudiCar : ICar
    {
        public string Model { get; set; }

        public AudiCar()
        {
            Model = Menu();
        }
        public string GetCarModel()
        {
            return Model;
        }


        public static string Menu()
        {
            bool loop = true;

            Console.WriteLine("Choose model");
            Console.WriteLine("1 - Audi E-Tron");
            while (loop)
            {
                string menuChoice = Console.ReadLine();
                switch (menuChoice)
                {
                    case "1":
                        ModelContext model = new ModelContext(new AudiEtron());
                        var createModel = model.CreateCarModel();
                        return createModel;                    
                    default:
                        break;
                    
                }
            }

            return null;
        }
    }
}
