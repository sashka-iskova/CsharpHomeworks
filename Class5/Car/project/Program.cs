using System;
using Models;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Driver driver1 = new Driver("Bob", 7);
            Driver driver2 = new Driver("Greg", 10);
            Driver driver3 = new Driver("Jill", 6);
            Driver driver4 = new Driver("Ane", 4);
            Car model1 = new Car("Hyundai", 200,driver1);
            Car model2 = new Car("Mazda", 120, driver2);
            Car model3 = new Car("Ferrari", 100, driver3);
            Car model4 = new Car("Porsche", 90, driver4);
           
            
            Console.WriteLine("Choose a car No.1:");
            Console.WriteLine($"1.{model1.Model}\n2.{model2.Model}\n3.{model3.Model}\n4.{model4.Model}");
            string firstCar = Console.ReadLine();
            if (firstCar == "1")
            {
                Console.WriteLine("Choose a car No.2:");
                Console.WriteLine($"1.{model2.Model}\n2.{model3.Model}\n3.{model4.Model}");
            }
            else if (firstCar == "2")
            {
                Console.WriteLine("Choose a car No.2:");
                Console.WriteLine($"1.{model1.Model}\n2.{model3.Model}\n3.{model4.Model}");
            }
            else if (firstCar == "3")
            {
                Console.WriteLine("Choose a car No.2:");
                Console.WriteLine($"1.{model1.Model}\n2.{model2.Model}\n3.{model4.Model}");
            }
            else if (firstCar == "4")
            {
                Console.WriteLine("Choose a car No.2:");
                Console.WriteLine($"1.{model1.Model}\n2.{model2.Model}\n3.{model3.Model}\n");
            }
            string secondCar = Console.ReadLine();
            
            Console.WriteLine("Choose a Driver:");
            Console.WriteLine($"1.{driver1.Name}\n2.{driver2.Name}\n3.{driver3.Name}\n4.{driver4.Name}");
            string firstDriver = Console.ReadLine();
            if (firstDriver == "1")
            {
                Console.WriteLine("Choose a Driver:");
                Console.WriteLine($"1.{driver2.Name}\n2.{driver3.Name}\n3.{driver4.Name}");
            }
            else if (firstDriver == "2")
            {
                Console.WriteLine("Choose a Driver:");
                Console.WriteLine($"1.{model1.Model}\n2.{model3.Model}\n3.{model4.Model}");
            }
            else if (firstDriver == "3")
            {
                Console.WriteLine("Choose a Driver:");
                Console.WriteLine($"1.{driver1.Name}\n2.{driver2.Name}\n3.{driver4.Name}");
            }
            else if (firstDriver == "4")
            {
                Console.WriteLine("Choose a Driver:");
                Console.WriteLine($"1.{driver1.Name}\n2.{driver2.Name}\n3.{driver3.Name}\n");
            }
            string secondDriver = Console.ReadLine();



            /*  string result =  Car.CalculateSpeed(driver1, model4);
               Console.WriteLine(result);
               string race = Car.RaceCar(model1, model4);
               Console.WriteLine(race);*/



        }


    }
}
