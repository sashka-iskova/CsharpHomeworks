using System;
using System.Globalization;


namespace Project_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your birthday:");
            string birthday = Console.ReadLine();
            birthday = birthday.Remove(0, 4);
            Int32.TryParse(birthday, out int res);
            int result = AgeCalc(res);
            Console.WriteLine($"You are {result} years old"); 
        }
        static public int AgeCalc(int res)
        {
            DateTime now = DateTime.Today;
            string today = now.ToString("yyyy");
            Int32.TryParse(today, out int today1);
            int result = today1 - res;
            return result;
        } 
    }
}

