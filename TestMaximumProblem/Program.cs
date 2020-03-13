using System;
using System.Linq;

namespace TestMaximumProblem
{
   public class  TestMaximumInteger
    {
        public double isDoubleArray(double number1, double number2, double number3)
        {
            double[] doubleNumber = { number1, number2, number3 };
            //Finding The Maximum double In Array
            double MaxValue = doubleNumber.Max();
            return MaxValue;
        }
        public static void Main(String[] args)
        {
            TestMaximumInteger tm = new TestMaximumInteger();

        }
    }
}
