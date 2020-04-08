using System;

namespace Flip_theBool
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Flip the bool
            Console.WriteLine("Enter true or false");
            string firstInput = Console.ReadLine();
            if (firstInput == "true")
            {
                Console.WriteLine("False");

            }
            else if (firstInput == "false")
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("Error, incorrect value");
                Console.WriteLine("Please enter true or false");
            }

        }
    }
}
