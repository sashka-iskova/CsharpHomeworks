using System;

namespace Project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence");
            string str = Console.ReadLine();
            string outputVowels = checkVowels(str);
            Console.WriteLine(outputVowels);
            string outputNumbers = checkNumbers(str);
            Console.WriteLine(outputNumbers); }
        static public string checkVowels(string userInput)
        {
            int vowel = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == 'a' || userInput[i] == 'e' || userInput[i] == 'i' || userInput[i] == 'o' || userInput[i] == 'u' || userInput[i] == 'A' || userInput[i] == 'E' || userInput[i] == 'I' || userInput[i] == 'O' || userInput[i] == 'U') 
                {
                    vowel++;
                }   
            }
            return $"The number of vowels is {vowel}";
        }
        static public string checkNumbers(string userInput)
        {
            int digitsCount = 0;
            foreach (char c in userInput)
            {
                if (Char.IsDigit(c))
                    digitsCount++;
            }
            return $"THe number of numbers is {digitsCount}";
        }
    }
}

