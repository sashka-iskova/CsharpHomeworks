using System;

namespace Future_predictions
{
    class Program
    {
        static void Main(string[] args)
        {

            //#9. Future prediction
            
            Console.WriteLine("Lets predict your future");
            Random rnd = new Random();
            int dice = rnd.Next(1, 5);
            if (dice == 1)
            {
                Console.WriteLine("You got a jackpot 1.000.000EUR");
            }
            else if(dice == 2)
            {
                Console.WriteLine("You will lost weights");
            }
            else if (dice ==3)
            {
                Console.WriteLine("Your boyfriend will break up with you!");
            }
            else if(dice == 4)
            {
                Console.WriteLine("Your cousine will buy you a dog!");
            }
            else if (dice == 5)
            {
                Console.WriteLine("You will leave 100 years!"); 
            }
        }
    }
}
