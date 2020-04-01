using System;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            //#10. Farenheit to Celsius conversion
            Console.WriteLine("Enter the amount of celsius:");
            int celsius = Int32.Parse(Console.ReadLine());
            double kelvin = celsius + 273.15;
            int fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Expected Output:");
            Console.WriteLine("Kelvin = "+ kelvin);
            Console.WriteLine("Fahrenheit = " + fahrenheit);
        }
    }
}
