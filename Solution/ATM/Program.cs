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

                if (userInput == "view balance")
                {
                    Console.WriteLine($"Your balance is {atm.ViewBalance()}");
                }
                else if (userInput == "exit")
                {
                    break;
                }
            }
           
        }

       
    }
}
