using System;
namespace ATM
{
    // Class of non static methods so we can initialize our class per test
    // So that it has its own instance of the class and the tests can run parallel

    public class ATM
    {
        // Variable to represent the account balance 
        private decimal balance;

        // Default constructor for ATM so that we can create multiple instances of balance
        public ATM()
        {
            // Initialize the inital balance as 0
            balance = 0;
        }

        // ATM constructor with default balance
        public ATM(decimal defaultBalance)
        {
            balance = defaultBalance;
        }

        // View Balance method
        public decimal ViewBalance()
        {
            return balance;
        }

        // Add Money method
        public void DepositMoney(decimal depositAmount)
        {
            if(depositAmount < 0)
            {
               throw new ArgumentException("Cannot deposit a negative amount.");
            }
            
            balance += depositAmount;
            
        }

        // Withdraw Money method
        public void WithdrawMoney(decimal withdrawAmount)
        {
            if(withdrawAmount > balance)
            {
                throw new ArgumentException("Withdraw amount exceeds your current balance.");
            } else if (withdrawAmount < 0)
            {
                throw new ArgumentException("Cannot withdraw a negative amount.");
            }

            balance -= withdrawAmount;
        }
    }
}
