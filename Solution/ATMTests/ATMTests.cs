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
            decimal balance = atm.ViewBalance();

            // Assert
            Assert.Equal(0, balance);
        }

        // Test adding money including subsequent deposits
        [Theory]
        [InlineData(5, 6, 11)]
        [InlineData(100, 101, 201)]
        public void DepositMoneyTest(decimal depositAmount1, decimal depositAmount2, decimal expected)
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

            // Act: Calling DepositMoney with negative amount but not executed yet
            Action depositNegative = () => atm.DepositMoney(-5);

            // Assert argument exception is thrown when negative amount is deposited
            ArgumentException exception = Assert.Throws<ArgumentException>(depositNegative);
            Assert.Equal("Cannot deposit a negative amount.", exception.Message);
        }


        // Test for withdrawing money
        [Theory]
        [InlineData(7, 4, 3)]
        [InlineData(100, 10, 90)]
        public void WithdrawMoneyTest(decimal initialBalance, decimal withdrawAmount, decimal expected)
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
