using System;

namespace Class02_Homework_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Average Number");
            Console.WriteLine("Enter the First Number");
            string firstInput = Console.ReadLine();
            int firstNumber = Int32.Parse(firstInput);
            Console.WriteLine("Enter the Second Number");
            string secondInput = Console.ReadLine();
            int secondNumber = Int32.Parse(secondInput);
            Console.WriteLine("Enter the Third Number");
            string thirdInput = Console.ReadLine();
            int thirdNumber = Int32.Parse(thirdInput);
            Console.WriteLine("Enter the Forth Number");
            string forthInput = Console.ReadLine();
            int forthNumber = Int32.Parse(forthInput);
            Console.WriteLine((firstNumber + secondNumber + thirdNumber + forthNumber) / 4);

        }
    }
}
