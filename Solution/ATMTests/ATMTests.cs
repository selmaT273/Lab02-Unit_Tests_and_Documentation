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
        [InlineData(5, 6, 11)]
        [InlineData(100, 101, 201)]
        public void DepositMoneyTest(int depositAmount1, int depositAmount2, int expected)
        {
            // Create an instance of ATM class by calling ATM constructor
            ATM atm = new ATM();
            // Calling DepositMoney with $5
            atm.DepositMoney(depositAmount1);
            atm.DepositMoney(depositAmount2);
            Assert.Equal(expected, atm.ViewBalance());
        }
    }
}
