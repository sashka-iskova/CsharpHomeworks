using System;
using Models;


namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {

           Atm atm = new Atm("ATM Machine");
           
            Customer customer1 = new Customer("Bob Ross", 1234123412341234, 1256, 1000);
            Customer customer2 = new Customer("Nick Kannon", 2635412987456125, 2232, 2530);
            Customer customer3 = new Customer("Drake Bell", 6395462874695135, 2233, 250);
            Customer customer4 = new Customer("Jonah Hill", 3333222211115555, 0021, 360);
            Customer customer5 = new Customer("Janice Bing", 6599441588762003, 7498, 1200);
            Customer customer6 = new Customer("David Blain", 7748555003612594, 9874, 970);
            Customer customer7 = new Customer("Sofia Vergara", 6329566310048579, 0100, 720);
            Customer customer8 = new Customer("James Morrison", 3322550010336699, 6565, 660);
            Customer customer9 = new Customer("Nelly Furdado", 6996366332232552, 9874, 250);
            Customer customer10 = new Customer("Tylor Swift", 7845123265988502, 6647, 450);
     
            atm.AddUser(customer1);
            atm.AddUser(customer2);
            atm.AddUser(customer3);
            atm.AddUser(customer4);
            atm.AddUser(customer5);
            atm.AddUser(customer6);
            atm.AddUser(customer7);
            atm.AddUser(customer8);
            atm.AddUser(customer9);
            atm.AddUser(customer10);


           Console.WriteLine("Wellcome to the ATM app");
          
            
            
                Console.WriteLine("Please enter your card number");
                string cardNum = Console.ReadLine();
                Int64.TryParse(cardNum, out long cardNumber);
                Console.WriteLine("Enter your pin number");
                string pinNum = Console.ReadLine();
                Int32.TryParse(pinNum, out int pinNumber);
               Customer.IsCardAndPinValid(atm, cardNumber, pinNumber);
            

                 //Customer.TransactionAction(atm);








            }
     }
  }

