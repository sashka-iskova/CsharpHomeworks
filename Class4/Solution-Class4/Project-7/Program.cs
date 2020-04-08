using System;

namespace Project_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number");
            string first = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string second = Console.ReadLine();
            if (Int32.TryParse(first, out int a) && Int32.TryParse(second, out int b))
            {
                int result = Raising(a, b);
                Console.WriteLine($"The number {a} to the power of {b} is: {result}");
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
        public static int Raising(double a, double b)
        {
            double x = Math.Pow(a, b);
            int xx = Convert.ToInt32(x);
            return xx;
        }
    }
    
}
