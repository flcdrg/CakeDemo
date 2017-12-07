using NUnit.Framework;

namespace CakeDemo
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void Addition()
        {
            Assert.AreEqual(4, 2 + 2);
        }

        [Test]
        public void Multiplication()
        {
            Assert.AreEqual(4, 2 * 2);
        }
    }
}
