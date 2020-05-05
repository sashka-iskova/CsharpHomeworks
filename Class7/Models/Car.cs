using System;
namespace Models
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }
        public int TopSpeed { get; set; }
        public Consumption Consumption { get; set; }

        public Car( string brand, string model, int doors, int topSpeed, Consumption consumption)
        {
            Brand = brand;
            Model = model;
            Doors = doors;
            TopSpeed = topSpeed;
            Consumption = consumption;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{Brand} \"{Model}\" it has {Doors} doors, the Top Speed is {TopSpeed} km/h.");
        }
    }
}
