using System;

namespace Profitable_gamble
{
    class Program
    {
        static void Main(string[] args)
        {
            //#4.  Profitable Gamble
            Console.WriteLine("Please enter the following:");
            Console.WriteLine("Please enter probability:");
            float prob = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter prize:");
            int prize = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter amount:");
            int pay = Int32.Parse(Console.ReadLine());
            if (prob * prize > pay)
            {
                Console.WriteLine("You won!");
            }
            else
            {
                Console.WriteLine("You lose");
            }
        }
    }
}
