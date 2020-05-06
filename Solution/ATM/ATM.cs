using System;
namespace ATM
{
    public class ATM
    {
        private int balance;

        // Default constructor for ATM
        public ATM()
        {
            // Initialize the inital balance as 0
            balance = 0;
        }

        // ATM constructor with default balance
        public ATM(int defaultBalance)
        {
            balance = defaultBalance;
        }

        // View Balance method
        public int ViewBalance()
        {
            return balance;
        }

        // Add Money method
        public void DepositMoney(int depositAmount)
        {
            balance += depositAmount;
        }

        // Withdraw Money method
        public void WithdrawMoney(int withdrawAmount)
        {
            balance -= withdrawAmount;
        }
    }
}
