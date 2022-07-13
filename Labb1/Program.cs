using Labb1.FactoryMethod;
using Labb1.Model;
using Labb1.Singleton;
using System;
using System.Collections.Generic;

namespace Labb1
{
    class Program
    {
        // Jag har använt mig av Factory Method, Singelton och Strategy
        // Hade kunnat gjort fler modeler men var lite sen att lämna in allt så hoppas det går bra


        public static List<ICar> cars = new List<ICar>();
        static void Main(string[] args)
        {

            bool loop = true;

            while (loop)
            {
                Console.WriteLine("1 - Create AudiCar");
                Console.WriteLine("2 - Create TeslaCar");
                Console.WriteLine("3 - Create VolvoCar");
                Console.WriteLine("4 - List all created cars");

                string menu = Console.ReadLine();


                switch (menu)
                {
                    case "1":
                        Console.Clear();
                        ICar car = new AudiFactory().CreateCar();
                        cars.Add(car);
                        break;
                    case "2":
                        Console.Clear();
                        ICar car2 = new TeslaFactory().CreateCar();
                        cars.Add(car2);
                        break;
                    case "3":
                        Console.Clear();
                        ICar car3 = new VolvoFactory().CreateCar();
                        cars.Add(car3);
                        break;
                    case "4":
                        Console.Clear();
                        if (cars != null)
                        {
                            foreach (var item in cars)
                            {
                                var carName = item.GetType();
                                Console.WriteLine("List of Cars: " + carName.Name + item.GetCarModel().ToString());
                            }
                        }
                        break;
                    default:
                        Console.Clear();
                        ErrorMessage error = ErrorMessage.GetInstance;
                        error.WrongInputMessage();
                        break;
                }

            }

        }
    }
}
