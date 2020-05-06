using System;
using Xunit;

namespace ATM
{
    public class ATMTests
    {
        [Fact]
        public void InitialBalanceZeroTest()
        {
            // Create an instance of ATM class by calling ATM constructor
            ATM atm = new ATM();
            Assert.Equal(0, atm.ViewBalance());
        }

        [Fact]
        public void DepositMoneyTest()
        {
            // Create an instance of ATM class by calling ATM constructor
            ATM atm = new ATM();
            // Calling DepositMoney with $5
            atm.DepositMoney(5);
            Assert.Equal(5, atm.ViewBalance());
        }
    }
}
