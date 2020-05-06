using System;
using Xunit;

namespace ATM
{
    public class ATMTests
    {
        [Fact]
        public void InitialBalanceZeroTest()
        {
            // Arrange: Create an instance of ATM class by calling ATM constructor
            ATM atm = new ATM();

            // Act
            int balance = atm.ViewBalance();

            // Assert
            Assert.Equal(0, balance);
        }

        // Test adding money including subsequent deposits
        [Theory]
        [InlineData(5, 6, 11)]
        [InlineData(100, 101, 201)]
        public void DepositMoneyTest(int depositAmount1, int depositAmount2, int expected)
        {
            // Arrange: Create an instance of ATM class by calling ATM constructor
            ATM atm = new ATM();

            // Act: Calling DepositMoney with amounts
            atm.DepositMoney(depositAmount1);
            atm.DepositMoney(depositAmount2);

            // Assert
            Assert.Equal(expected, atm.ViewBalance());
        }

        // Test if user tries to deposit a negative amount 
        [Fact]
        public void DepositNegativeAmountTest()
        {
            // Arrange: Create an instance of ATM class by calling ATM constructor
            ATM atm = new ATM(100);

            // Act: Calling DepositMoney with negative amount
            atm.DepositMoney(-5);

            // Assert
            Assert.Equal(expected, atm.ViewBalance());
        }


        // Test for withdrawing money
        [Theory]
        [InlineData(7, 4, 3)]
        [InlineData(100, 10, 90)]
        public void WithdrawMoneyTest(int initialBalance, int withdrawAmount, int expected)
        {
            // Arrange: Create an instance of ATM class by calling ATM constructor
            ATM atm = new ATM(initialBalance);

            // Act: Calling WithdrawMoney with amounts passed in
            atm.WithdrawMoney(withdrawAmount);

            //Assert
            Assert.Equal(expected, atm.ViewBalance());
        }
    }
}
