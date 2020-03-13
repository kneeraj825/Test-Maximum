using NUnit.Framework;
using TestMaximumProblem;

namespace NUnitTestMaximum
{
    [TestFixture]
    public class TestMax
    {

        [Test]
        public void Max_ReturnIntegerValue()
        {
            TestMaximumInteger md = new TestMaximumInteger();
            double actualMaxInteger = md.isIntegerArray(10, 15, 14);
            Assert.AreEqual(15, actualMaxInteger);
        }
        [Test]
        public void Max_Double()
        {
            TestMaximumInteger md = new TestMaximumInteger();
            double actualMaxDouble = md.isDoubleArray(10.5, 15.2, 14.3);
            Assert.AreEqual(15.2, actualMaxDouble);
        }
       
    }

    
}