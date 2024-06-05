using NUnit;

namespace NTest
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
            Assert.AreEqual(1, 2);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, 3);
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(1, 1);
        }
    }
}