using System;

namespace Class02_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Real Calculator");
            Console.WriteLine("Please enter first number");
            int firstInteger = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What operation would you like to be done?");
            string operation = Console.ReadLine();
            Console.WriteLine("Please enter second number");
            int secondInteger = Int32.Parse(Console.ReadLine());
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
