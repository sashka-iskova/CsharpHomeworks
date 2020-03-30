using System;

namespace Class02_Homework_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Swap Numbers");
            Console.WriteLine("Input the first number");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number");
            int y = Int32.Parse(Console.ReadLine());
            x = x + y; 
            y = x - y; 
            x = x - y;
            Console.WriteLine("Output after swaping");
            Console.WriteLine("The value for x is: " + x);
            Console.WriteLine("The value for y is: " + y);
        }
    }
}
