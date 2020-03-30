using System;

namespace Class02_Homework_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Average Number");
            Console.WriteLine("Enter the First Number");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int secondNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Third Number");
            int thirdNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Forth Number");
            int forthNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The average number is: " + ((firstNumber + secondNumber + thirdNumber + forthNumber) / 4));
        }
    }
}
