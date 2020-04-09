using System;
using Model;

namespace Task1_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your dogs name");
            string dogName = Console.ReadLine();
            Console.WriteLine("Please enter your dogs race");
            string dogRace = Console.ReadLine();
            Console.WriteLine("Please enter your dogs color");
            string dogColor = Console.ReadLine();
            Dog dog1 = new Dog(dogName, dogRace, dogColor);
            Console.WriteLine("What would you like your dog to do?\nPlease select a number:");
            Console.WriteLine("1. Eat");
            Console.WriteLine("2. Play");
            Console.WriteLine("3. Chase its tail");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine($"Your dogs name is {dog1.Name} its race is {dog1.Race} and {dog1.eat()}");
            }
            else if (choice == "2")
            {
                Console.WriteLine($"Your dogs name is {dog1.Name} its race is {dog1.Race} and {dog1.play()}");
            }
            else if (choice == "3")
            {
                Console.WriteLine($"Your dogs name is {dog1.Name} its race is {dog1.Race} and {dog1.ChaseTail()}");
            }
        }

    }
}
