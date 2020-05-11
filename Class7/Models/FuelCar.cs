using System;

namespace Models
{
    public class FuelCar : Car
    {
        public int FuelCapacity { get; set; }
        public double CurrentFuel { get; set; }
        public EngineType EngineType { get; set; }

        public FuelCar(string brand, string model, int doors, int topSpeed, int fuelCapacity, int currentFuel, Consumption consumption, EngineType engineType)
            : base(brand, model, doors, topSpeed, consumption)
        {
            FuelCapacity = fuelCapacity;
            CurrentFuel = currentFuel;
            EngineType = engineType;
        }
        public void Drive(int distance)
        {
            int fuelUsed = 0;
            if (Consumption == Consumption.Economic)
                fuelUsed = (distance * 1) / 10;
            if (Consumption == Consumption.Medium)
                fuelUsed = (distance * 2) / 10;
            if (Consumption == Consumption.High)
                fuelUsed = (distance * 3) / 10;
            double used = (fuelUsed * 100) / FuelCapacity;
            if (used > 100)
            {
                Console.WriteLine($"I'm sorry, you have used the total ammount of fuel of this car.");
            }
            else if(used < 100)
                {
                CurrentFuel = used;
            }
        }
        public void ReFuel(int inputFuel)
        {
            CurrentFuel += inputFuel;
            if (CurrentFuel > FuelCapacity)
            {
                {
                    Console.WriteLine($"Can't refuel more than {FuelCapacity} liters");
                }
            }
        }
    }
}