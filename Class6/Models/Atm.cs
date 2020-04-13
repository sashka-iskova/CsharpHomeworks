using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Atm
    {
        public string Name { get; set; }
        public List<Customer> Customers { get; set; }

        public Atm(string name)
        {
            Name = name;
            Customers = new List<Customer>();
        }

        public void AddUser(Customer customer)
        {
            foreach (Customer c in Customers)
            {
                if (customer.Name == c.Name)
                    return;
            }
            Customers.Add(customer);
        }

      

            


        /*        public void IsCardValid(string cardNum)
                {

                    for (int i = 0; i <= cardNum.Length; i++)
                    {
                        long x;
                        if (cardNum.Length != 16)
                        {
                            Console.WriteLine("You have entered invalid card number, please try again");
                            break;
                        }

                        else if (Int64.TryParse(cardNum, out x))
                        {
                            Console.WriteLine("Thank you for entering valid card number");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You have entered invalid card number, please try again");
                            break;
                        }*/

                    }
                }
            

        




/*
            public static long IsCardValid(string inputCard)
            {
                if (Int64.TryParse(inputCard, out long card))
                {

                    Console.WriteLine("Please enter your pin number");
                }
                else
                {
                    Console.Write("You have entered wrond card number.Please try again");
                }

                return card;
            }*/