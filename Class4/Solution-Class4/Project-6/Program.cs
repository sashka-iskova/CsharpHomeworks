using System;

namespace Project_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string firstSentence = Console.ReadLine();
            Console.WriteLine("Enter the word to search for:");
            string sentenceToSearch = Console.ReadLine();
            Console.Write(Substr(firstSentence, sentenceToSearch));
        }
      
           static int Substr(string str,string word)
        {
            string[] arr = str.Split(' ');
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (word.Equals(arr[i]))
                    count++;
            }
            return count;
        }
    }
}
