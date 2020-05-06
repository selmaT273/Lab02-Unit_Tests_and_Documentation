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

        [Theory]
        [InlineData(5, 5)]
        public void DepositMoneyTest(int depositAmount, int expected)
        {
            // Create an instance of ATM class by calling ATM constructor
            ATM atm = new ATM();
            // Calling DepositMoney with $5
            atm.DepositMoney(depositAmount);
            Assert.Equal(expected, atm.ViewBalance());
        }
    }
}
