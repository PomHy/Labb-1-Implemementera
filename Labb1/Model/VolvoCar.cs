using Labb1.Strategy.Tesla;
using Labb1.Strategy;
using System;
using System.Collections.Generic;
using System.Text;
using Labb1.Strategy.Volvo;

namespace Labb1.Model
{
    class VolvoCar : ICar
    {
        public string Model { get; set; }

        public VolvoCar()
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
            Console.WriteLine("1 - Volvo V90");
            while (loop)
            {
                string menuChoice = Console.ReadLine();
                switch (menuChoice)
                {
                    case "1":
                        ModelContext model = new ModelContext(new VolvoV90());
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
