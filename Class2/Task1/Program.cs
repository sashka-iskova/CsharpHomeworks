using System;

namespace Class02_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Real Calculator");
            Console.WriteLine("Please enter first number");
            string firstInput = Console.ReadLine();
            int firstInteger = Int32.Parse(firstInput);
            Console.WriteLine("What operation would you like to be done?");
            string operation = Console.ReadLine();
            Console.WriteLine("Please enter second number");
            string secondInput = Console.ReadLine();
            int secondInteger = Int32.Parse(secondInput);
            if (operation == "+")
            {
                Console.WriteLine(firstInteger + secondInteger);
            }
            else if (operation == "-")
            {
                Console.WriteLine(firstInteger - secondInteger);
            }
            else if (operation == "*")
            {
                Console.WriteLine(firstInteger * secondInteger);
            }
            else if (operation == "/")
            {
                Console.WriteLine(firstInteger / secondInteger);
            }
        }
    }
}
