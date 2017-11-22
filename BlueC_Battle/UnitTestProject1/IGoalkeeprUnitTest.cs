using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlueC_Battle;

namespace UnitTestProject1
{
    [TestClass]
    public class IGoalkeeprUnitTest
    {
        [TestMethod]
        public void TestPrefix()
        {
            // Arrange
            string challenge = "+ 2 3";
            int expected = 5;
            var goalKeeper = new Goalkeeper();

            // Act
            int result = goalKeeper.AcceptChallenge(challenge);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestInfix()
        {
            // Arrange
            string challenge = "2 + 3";
            int expected = 5;
            var goalKeeper = new Goalkeeper();

            // Act
            int result = goalKeeper.AcceptChallenge(challenge);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
