using System;


namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 6 numbers");
            string[] answer = new string[6];
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = Console.ReadLine();
            }
            int[] intsArr = Array.ConvertAll(answer, s => int.TryParse(s, out int x) ? x : 0);  
            int highestValue = checkValue(intsArr);
            Console.WriteLine($"The highest number in the array is: {highestValue}");
        }     
        static int checkValue(int[] inputArray)
        {
            int num = inputArray[0];
            for(int i = 0; i <inputArray.Length; i++)
            {
                if (num < inputArray[i])
                    num = inputArray[i];
            }
            return num;
        }
    }
}
