using System;
using System.Threading;

namespace Class01_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Traffic light....");
            Console.WriteLine();
            Thread.Sleep(1500);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Red light - STOP!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Thread.Sleep(1500);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Yellow light - PREPARE.");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Thread.Sleep(1500);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Green light - GO!");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
