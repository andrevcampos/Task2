using Task2;

namespace TestProject5
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            [TestMethod]
            public void Deposit_ValidAmount_Success()
            {
                // Arrange
                Account account = new Everyday(1000);
                decimal depositAmount = 200;

                // Act
                account.Deposit((int)depositAmount);

                // Assert
                Assert.AreEqual(1200, account.GetBalance);
            }
        }
    }
}