using System;
using Xunit;

namespace ATM
{
    public class ATMTests
    {
        [Fact]
        public void InitialBalanceZeroTest()
        {
            // Create an instance of ATM class
            ATM atm = new ATM();
            Assert.Equal(0, atm.ViewBalance());
        }
    }
}
