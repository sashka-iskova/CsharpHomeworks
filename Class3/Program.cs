using System;

namespace Class03_Homework_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Sum of Even");
            string[] arr = new string[6];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
            int[] numArr = Array.ConvertAll(arr, int.Parse);
            foreach (int i in numArr)
            {
                Console.Write("{0} ", i);

                if (numArr[i] % 2 == 0)
                {

                    // int sum = sum + numArr[i];
                }
                else
                {
                    Console.WriteLine("error");
                }
            }*/

            Console.WriteLine("StudentGroup");

            string[] studentsG1 = new string[5] {"Marija","Andrej", "Stefan", "Hristina", "Maja" };
            string[] studentsG2 = new string[5] { "Aleksandar", "Goran", "Iva", "Teodora", "Ana" };
            Console.WriteLine("Please enter a number between 1 and 2");
            int firstInput = Int32.Parse(Console.ReadLine());
            if(firstInput == 1)
            {
                Console.WriteLine("The students of G1 are:");
                Console.WriteLine(String.Join(",",studentsG1));
            }
            else if (firstInput ==2)
            {
                Console.WriteLine("The students of G2 are:");
                Console.WriteLine(String.Join(",",studentsG2));
            }
            else
            {
                Console.WriteLine("error");
            }





        }

    }
}
