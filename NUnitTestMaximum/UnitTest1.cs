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
            int actualMaxInteger = Test.TestMaximumValue<int>.maxValueArray(10, 15, 14);
            Assert.AreEqual(15, actualMaxInteger);
        }
        [Test]
        public void Max_Double()
        {

            double actualMaxInteger = Test.TestMaximumValue<double>.maxValueArray(10.2, 15.6, 14.6);
            Assert.AreEqual(15.6, actualMaxInteger);
        }
        [Test]
        public void Max_String()
        {

            int actualMaxInteger = Test.TestMaximumValue<string>.maxValueArray("the".Length, "corona".Length, "virus".Length);
            Assert.AreEqual(6, actualMaxInteger);
        }

    }

    
}