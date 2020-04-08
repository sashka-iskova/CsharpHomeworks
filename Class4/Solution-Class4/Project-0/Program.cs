using System;

namespace Project_0
{
    class Program
    {
         //## Task 0
         //Create a new method called Substrings
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string input = Console.ReadLine();
            Int32.TryParse(input, out int x);
            string output = Substrings(x);
        }

        static public string Substrings(int n)
        {
            string sentence = "Hello from SEDC Codecademy v7.0";
            if (n >= 1 && n <= sentence.Length)
            {
                Console.WriteLine("You have entered valid number");
            }
            else
            {
                Console.WriteLine("You have entered invalid number");
            }
            string newString = sentence.Substring(n);
            char first = sentence[n];
            Console.WriteLine($"The frist character of the input is \"{first}\"\nThe length of the new string is: {newString.Length}");
            return newString;
        }
    }
}
