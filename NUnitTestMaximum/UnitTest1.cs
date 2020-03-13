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
            double actualMax = md.isDoubleArray(10.5, 15.2, 14.3);
            Assert.AreEqual(15.2, actualMax);
        }
    }

    
}