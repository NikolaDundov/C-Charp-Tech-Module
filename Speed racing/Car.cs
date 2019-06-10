using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public string Model
        {
            get => this.model;
            set => this.model = value;
        }

        public double FuelAmount
        {
            get => this.fuelAmount;
            set => this.fuelAmount = value;
        }

        public double FuelConsumptionPerKilometer
        {
            get => this.fuelConsumptionPerKilometer;
            set => this.fuelConsumptionPerKilometer = value;
        }

        public double TravelledDistance
        {
            get => this.travelledDistance;
            set => this.travelledDistance = value;
        }

        public void TraveledDistance(double fuelAmount,
            double fuelConsumptionPerKilometer, double travelledDistance)
        {
            if (FuelAmount >= (FuelConsumptionPerKilometer * travelledDistance))
            {
                FuelAmount -= (FuelConsumptionPerKilometer * travelledDistance);
                TravelledDistance += travelledDistance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

        }
    }
}
