using System;

namespace Coffee_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            //#8. Coffe machine
            Console.WriteLine("Welcome dear customer");
            Console.WriteLine("1. Espresso...........2$");
            Console.WriteLine("2. Macchiato........3,5$");
            Console.WriteLine("3. Latte..............4$");
            Console.WriteLine("4. Cappuccino.........6$");
            Console.WriteLine("5. Tea..............1.5$");
            Console.WriteLine("Please select drink");
            string selectedDrink = Console.ReadLine();
            if (int.TryParse(selectedDrink, out int drink))
            {
                Console.WriteLine("Thank you for choosing");
            }
            else
            {
                Console.WriteLine("Please enter valid number");
            }
            Console.WriteLine("Please select sweetness");
            int selectSweetness = Int32.Parse(Console.ReadLine());
            /*
            Console.WriteLine("Please select sweetness level: 1 - 5 ");
            
            Console.WriteLine("Please insert your money");
            */
        }
    }
}
