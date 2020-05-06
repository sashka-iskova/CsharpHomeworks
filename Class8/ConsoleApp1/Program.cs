using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>() { "String #1", "String #2", "String #3", "String #4", "String #5" };
            foreach (string str in strings)
            {
                Console.WriteLine($"This is: {str}");
            }

            Queue<int> queues = new Queue<int>();
            queues.Enqueue(653);
            queues.Enqueue(3521);
            queues.Enqueue(463);
            queues.Enqueue(563);
            queues.Enqueue(356);
            int x = queues.Dequeue();
            Console.WriteLine($"The number in front of the queue is: {x}");

            Stack<int> stacks = new Stack<int>();
            stacks.Push(2353);
            stacks.Push(221);
            stacks.Push(22);
            stacks.Push(589);
            stacks.Push(123);
            int y = stacks.Pop();
            Console.WriteLine($"The number in front of the queue is: {y}");
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("Marko", 123453328);
            dictionary.Add("Marija", 346890699);
            dictionary.Add("Elena", 323676598);
            dictionary.Add("Bojan", 524574125);
            dictionary.Add("Mila", 885363987);
            foreach (KeyValuePair<string, int> xy in dictionary)
            {
                 Console.WriteLine($"Name: {xy.Key} | Phone Number: {xy.Value}");
            }
        }
    }
}
