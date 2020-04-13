using System;
using System.Collections.Generic;
namespace Models
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }
        
        public Car(string model, int speed, Driver driver)
        {
            Model = model;
            Speed = speed;
            Driver = driver;
        }
        public static string CalculateSpeed(Driver driver, Car car)
        {
            int result = car.Speed * driver.Skill;
            return $"The speed of this car is {result} km/h.";
        }
       public static string RaceCar(Car car1, Car car2)
        {
            if (car1.Speed > car2.Speed)
            {
                Console.WriteLine("---------------");
            }
            string result = $"The {car1.Model} won!";
            return result; 
        }
        public void ChooseCar()
        {
            
        }
        
       
    }
}
