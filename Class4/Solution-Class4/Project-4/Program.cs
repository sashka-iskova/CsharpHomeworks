using System;

namespace Project_4
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Please enter your string");
                string str = Console.ReadLine();
                string result = Sentence(str);
                Console.WriteLine(result);
         }
            static public string Sentence(string a)
            {
                char ch;
                int l = a.Length;
                char[] arr1 = a.ToCharArray(0, l);
                Console.Write("\nAfter conversion, the string is: ");
                for (int i = 0; i < l; i++)
                {
                    ch = arr1[i];
                    if (Char.IsLower(ch))
                        Console.Write(Char.ToUpper(ch)); 
                    else
                        Console.Write(Char.ToLower(ch));
                }
                return string.Empty;
            }
        } 
}
