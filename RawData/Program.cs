using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Car> carsList = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                double tire1Pressure = double.Parse(input[5]);
                int tire1Age = int.Parse(input[6]);
                double tire2Pressure = double.Parse(input[7]);
                int tire2Age = int.Parse(input[8]);
                double tire3Pressure = double.Parse(input[9]);
                int tire3Age = int.Parse(input[10]);
                double tire4Pressure = double.Parse(input[11]);
                int tire4Age = int.Parse(input[12]);


                Car myCar = new Car(model, new Engine(engineSpeed, enginePower), new Cargo(cargoWeight, cargoType),
                    new List<Tire>  { new Tire(tire1Age, tire1Pressure), new Tire(tire2Age, tire2Pressure),
                        new Tire(tire3Age, tire3Pressure), new Tire(tire4Age, tire4Pressure) });

                carsList.Add(myCar);
            }

            string dataToCheck = Console.ReadLine();


            if (dataToCheck == "fragile")
            {
                foreach (var car in carsList.Where(x => x.cargo.cargoType == "fragile").Where(c => c.tires.Any(p => p.tirePressure < 1)))
                {

                    Console.WriteLine(car.model);

                }
            }

            else if (dataToCheck == "flamable")
            {
                foreach (var car in carsList.Where(x => x.cargo.cargoType == "flamable").Where(p => p.engine.enginePower > 250))
                {
                    Console.WriteLine(car.model);

                }
            }
        }
    }
}
