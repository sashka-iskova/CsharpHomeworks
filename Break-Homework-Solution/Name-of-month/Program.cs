using System;

namespace Name_of_month
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Return name of month
            Console.WriteLine("Please enter a number from 1 to 12");
            int number1 = Int32.Parse(Console.ReadLine());
            //number1 = 4;
            switch (number1)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Error, incorrect value. Please enter a valid number");
                    break;
            }
            
           
        }
    }
}
