using System;

namespace Project_1
{
    class Program
    { 
        //Task-1
        //Check if string is palindrome
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string");
            string user = Console.ReadLine();
            string output = Palindrome(user);
        }
   
        static public string Palindrome(string userInput)
        {
            char[] toChar = userInput.ToCharArray();
            Array.Reverse(toChar);
            string reversed = new string(toChar);
            bool b = userInput.Equals(reversed, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine($"{userInput} is a Palindrome!");
            }
            else
            {
                Console.WriteLine($"{userInput} is not a Palindrome!");
            }
            return reversed;
        }
    }
}
