using System;

namespace ATM
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DeltaV Bank");

            // Instantiate the ATM class
            ATM atm = new ATM();

            // Keep prompting until user exits
            while (true)
            {
                // Prompt user with options
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("View Balance \n" +
                                  "Deposit Money \n" +
                                  "Withdraw Money \n" +
                                  "Exit");
                string userInput = Console.ReadLine().ToLower();

                // Eventually put "try" here

                if (userInput == "view balance")
                {
                    Console.WriteLine($"Your balance is {atm.ViewBalance()}");
                }
                else if (userInput == "deposit money")
                {
                    Console.WriteLine($"How much would you like to deposit?");
                    decimal depositAmount = decimal.Parse(Console.ReadLine());

                    // Call Deposit Money to update balance
                    atm.DepositMoney(depositAmount);

                    Console.WriteLine($"You deposited ${depositAmount}. \n" +
                                      $"Your new balance is {atm.ViewBalance()}");
                }
                else if (userInput == "withdraw money")
                {
                    Console.WriteLine($"How much would you like to withdraw?");
                    decimal withdrawAmount = decimal.Parse(Console.ReadLine());

                    // Call Withdraw Money to update balance
                    atm.WithdrawMoney(withdrawAmount);

                    Console.WriteLine($"You withdrew ${withdrawAmount}. \n" +
                                      $"Your new balance is {atm.ViewBalance()}");
                }
                else if (userInput == "exit")
                {
                    break;
                }

                // Catch here
            }
           
        }

       
    }
}
