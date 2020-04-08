using System;

namespace Word_count
{
    class Program
    {
        static void Main(string[] args)
        {
            //#6. Word Count
            Console.WriteLine("Please enter a sentence");
            string sentence = Console.ReadLine();
            int wordCount = 0, index = 0;

            // skip whitespace until first word
            while (index < sentence.Length && char.IsWhiteSpace(sentence[index]))
                index++;

            while (index < sentence.Length)
            {
                // check if current char is part of a word
                while (index < sentence.Length && !char.IsWhiteSpace(sentence[index]))
                    index++;

                wordCount++;

                // skip whitespace until next word
                while (index < sentence.Length && char.IsWhiteSpace(sentence[index]))
                    index++;
            }



        }
    }
}
