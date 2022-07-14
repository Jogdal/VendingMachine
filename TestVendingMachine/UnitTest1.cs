using VendingMachine;

namespace TestVendingMachine
{
    public class UnitTest1
    {
        [Fact]
        public void CheckMinBalance()
        {
            bool sut = CommonMethods.CheckMinBalance(10);
            Assert.True(sut);
        }
        [Fact]
        public void CheckDepositValue()
        {
            bool sut = CommonMethods.CheckDeposit(1000);
           

            Assert.True(sut);
        }
        [Fact]
        public void CheckCashToDispence()
        {
            bool sut = CommonMethods.CheckCashToDispence(1);
            Assert.True(sut);
        }

        [Fact]
        public void CheckIfTheUserIsACheepMotherF()
        {
            bool sut = CommonMethods.CheckIfTheUserIsACheepMotherF(1);
            Assert.True(sut);
        }
    }
    
}