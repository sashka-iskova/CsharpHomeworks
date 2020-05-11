using System;
namespace Models
{
   public class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }
        public double BatteryUsed { get; set; }
        public EngineType EngineType { get; set; }
        
        public ElectricCar(string brand, string model, int doors, int topSpeed, int batteryCapacity, Consumption consumption)
            :base(brand, model, doors, topSpeed, consumption)
        {
            BatteryCapacity = batteryCapacity;
            EngineType = EngineType.Electric;     
        }
        public void Drive(int distance)
        {
            
            int bateryUsed = 0;
            if (Consumption == Consumption.Economic)
                bateryUsed = (distance * 1) / 10;
            if (Consumption == Consumption.Medium)
                bateryUsed = (distance * 2) / 10;
            if (Consumption == Consumption.High)
                bateryUsed = (distance * 3) / 10;
            double x = (bateryUsed * 100) / BatteryCapacity;
            if (x > 100)
            {
                Console.WriteLine($"I'm sorry, you have used the total ammount of energy of this car.");
                BatteryUsed = 0;
            }
            else if(x < 100)
            {
                BatteryUsed = x;
            }

           

        }
        public void Recharge(int inputMins)
            {
             double batteryLeft = 100 - BatteryUsed;
             int percents = (1 / 10) * inputMins;  
             batteryLeft += percents;
             BatteryUsed = 100 - batteryLeft;
            if (batteryLeft > 100)
            {
                Console.WriteLine($"You can't charge more than {inputMins} minutes");
                batteryLeft = 100;
                BatteryUsed = 0;
            }
    }
    }
}
