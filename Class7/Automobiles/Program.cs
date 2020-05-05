using System;
using Models;

namespace Automobiles
{
    class Program
    {
        static void Main(string[] args)
        {

         
            ElectricCar elCar1 = new ElectricCar("Mahindra", "e2o plus", 4, 230, 100, Consumption.High);
            ElectricCar elCar2 = new ElectricCar("Audi", "Q2 L e-Tron", 2, 250, 85, Consumption.Economic);
            ElectricCar elCar3 = new ElectricCar("Chery", "QQ3",5,225,105, Consumption.Medium);
            
            FuelCar fuCar1 = new FuelCar("Peugeot","208 II", 4,260,102, 1234,Consumption.Medium, EngineType.Petrol);
            FuelCar fuCar2 = new FuelCar("Mazda", "208 II", 4, 280, 95,468, Consumption.Economic, EngineType.Diesel);
            FuelCar fuCar3 = new FuelCar("Porsche", "Taycan", 4, 300, 110,2357, Consumption.High,EngineType.Diesel);


            elCar1.Drive(346);
            elCar2.Drive(234);
            elCar3.Drive(112);
            Console.WriteLine("***********************************************");
            fuCar1.Drive(742);
            fuCar2.Drive(345);
            fuCar3.Drive(532);

            Console.WriteLine("***********************************************");
            elCar1.Recharge(234);
            elCar2.Recharge(112);
            elCar3.Recharge(23);

            Console.WriteLine("***********************************************");
            fuCar1.ReFuel(241);
            fuCar2.ReFuel(236);
            fuCar3.ReFuel(321);

            Console.WriteLine("***********************************************");
            elCar1.PrintInfo();
            elCar2.PrintInfo();
            elCar3.PrintInfo();

            Console.WriteLine("***********************************************");
            fuCar1.PrintInfo();
            fuCar2.PrintInfo();
            fuCar3.PrintInfo();
        }     
    }
}
