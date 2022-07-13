using Labb1.Strategy;
using System;
using System.Collections.Generic;
using System.Text;
using Labb1.Strategy.Tesla;

namespace Labb1.Model
{
    class TeslaCar : ICar
    {
        public string Model { get; set; }

        public TeslaCar()
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
            Console.WriteLine("1 - Tesla model S");
            while (loop)
            {
                string menuChoice = Console.ReadLine();
                switch (menuChoice)
                {
                    case "1":
                        ModelContext model = new ModelContext(new ModelS());
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
