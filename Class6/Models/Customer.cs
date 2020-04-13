using System;
using System.Collections.Generic;
using System.Globalization;

namespace Models
{
    public class Customer
    {
        public string Name { get; set; }
        public long CardNumber { get; set; }
        private int PinNumber { get; }
        private int Balance { get; set; }


        public Customer(string name, long cardNum, int pinNum, int balance)
        {
            Name = name;
            CardNumber = cardNum;
            PinNumber = pinNum;
            Balance = balance;
        }

        public static void IsCardAndPinValid(Atm atm, long cardNumber, int pinNum)
        {
            for (int i = 0; i < atm.Customers.Count; i++)
            {
                if ((atm.Customers[i].CardNumber == cardNumber) && (atm.Customers[i].PinNumber == pinNum))
                {
                    Console.WriteLine($"Wellcome {atm.Customers[i].Name}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again");
                    break;
                }
            }
        }
        public static void TransactionAction(Atm atm )
        {
            for (int i = 0; i < atm.Customers.Count; i++)
           {
                    Console.WriteLine(" ");
                    Console.WriteLine("What would you like to do:");
                    Console.WriteLine("1) Check balance\n2) Cash withdrawal\n3) Cash deposit");
                    string pickAction = Console.ReadLine();
                    Int32.TryParse(pickAction, out int choice);
                    switch (choice)
                    {
                        case 1:

                            Console.WriteLine($"Your balance is: {atm.Customers[i].Balance}");
                            break;
                        case 2:
                            Console.WriteLine("Enter how much you would like to withdrawl:");
                            string ammount = Console.ReadLine();
                            Int32.TryParse(ammount, out int cashAmmount);
                            if (cashAmmount <= atm.Customers[i].Balance)
                            {
                                Console.WriteLine($"You have successfully withdrown {cashAmmount}");
                                Console.WriteLine($"You have {atm.Customers[i].Balance = atm.Customers[i].Balance - cashAmmount} left on your account");
                            break;
                            }
                            else if (cashAmmount > atm.Customers[i].Balance)
                            {
                                Console.WriteLine("You don't have the desired ammount on your card");
                            }
                            break;
                        case 3:
                        Console.WriteLine("How much would you like to deposit?");
                        string deposit = Console.ReadLine();
                            Int32.TryParse(deposit, out int cashDeposit);
                        if(cashDeposit != 0)
                        {
                            Console.WriteLine($"You now have {atm.Customers[i].Balance = atm.Customers[i].Balance + cashDeposit} on your card");
                        } break;
                        case 4:
                        {
                            Console.WriteLine("Thank you for using this ATM machine");
                            break;
                        }
                    }
                
                }

        }
    }
}
    


