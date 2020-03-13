using NUnit.Framework;
using TestMaximumProblem;

namespace NUnitTestMaximum
{
    [TestFixture]
    public class TestMax
    {
        [Test]
        public void Max_ReturnsExpectedValue()
        {
            TestMaximumInteger md = new TestMaximumInteger();
            int actualMax = md.maximumInteger(10, 15, 14);
            Assert.AreEqual(15, actualMax);
        }
    }

    
}