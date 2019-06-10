using System;
using System.Linq;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> carsList = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                string make = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionFor1km = double.Parse(input[2]);

                Car currentCar = new Car();
                currentCar.Model = make;
                currentCar.FuelAmount = fuelAmount;
                currentCar.FuelConsumptionPerKilometer = fuelConsumptionFor1km;

                if (!carsList.Contains(currentCar))
                {
                    carsList.Add(currentCar);
                }

            }

            string token = Console.ReadLine();

            while (token.ToLower() != "end")
            {
                var input = token.Split().ToArray();
                string model = input[1];
                double distanceToTravel = double.Parse(input[2]);


                foreach (var car in carsList)
                {
                    if (car.Model == model)
                    {
                        car.TraveledDistance(car.FuelAmount, car.FuelConsumptionPerKilometer, distanceToTravel);
                    }
                }

                token = Console.ReadLine();
            }

            foreach (var car in carsList)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
