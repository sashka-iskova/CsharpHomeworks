using System;

namespace The_farm_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //#5. The Farm Problem
            Console.WriteLine("Let me tell you how many legs you have among all your animals");
            Console.WriteLine("Please enter number of chickens:");
            int chickens = Int32.Parse(Console.ReadLine()) * 2;
            Console.WriteLine("Please enter number of cows:");
            int cows = Int32.Parse(Console.ReadLine()) * 4;
            Console.WriteLine("Please enter number of pigs:");
            int pigs = Int32.Parse(Console.ReadLine()) * 4;
            int total = chickens+cows+pigs;
            Console.WriteLine("Total amount of legs: " + total);
        }
    }
}
