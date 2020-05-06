using System;
namespace ATM
{
    public class ATM
    {
        private int balance;

        // Constructor
        public ATM()
        {
            // Initialize the inital balance as 0
            balance = 0;
        }

        public int ViewBalance()
        {
            return balance;
        }
        public void DepositMoney(int depositAmount)
        {
            balance += depositAmount;
        }
    }
}
