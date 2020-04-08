using System;

namespace Project_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a character: ");
            char character = (char)Console.Read();
            char result = checkIfIsChar(character);
        }

        static public char checkIfIsChar(char x)
        {
            char y = x;
            if(Char.IsLetter(y))
            {
                Console.WriteLine("The entered character is an alphabetic character");
            }
            else
            {
                Console.WriteLine("The entered character is not an alphabetic character.");
            }
            return y;
        }
    }
}
