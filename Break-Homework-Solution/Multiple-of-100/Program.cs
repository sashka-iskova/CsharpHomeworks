using System;

namespace Multiple_of_100
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Multiple of 100
          
           Console.WriteLine("Please enter a number");
            string input1 =Console.ReadLine();
            int num;
   
           if (int.TryParse(input1, out num) && num % 100 == 0)
            {
                Console.WriteLine("You have entered a cool number!");
            }
            else if(int.TryParse(input1, out num) && num % 100 == 1)
            {
                Console.WriteLine("The number you've entered is not cool at all!");
            }
           else
            {
                Console.WriteLine("Can't you read? Enter a number, not anything else!");
            }
         
        }
    }
}
