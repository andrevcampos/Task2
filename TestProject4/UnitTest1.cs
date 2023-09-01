using Task2;

namespace TestProject4
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
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