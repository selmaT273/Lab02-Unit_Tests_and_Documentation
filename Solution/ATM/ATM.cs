using System;
namespace ATM
{
    public class ATM
    {
        // Constructor
        public ATM()
        {
            // Initialize the inital balance as 0
            Balance = 0;
        }

        // Creating a Balance property/variable that can change in value and be retrieved
        private int Balance { get; set; }

        public int ViewBalance()
        {
            return Balance;
        }
    }
}
