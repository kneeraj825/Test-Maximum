using System;
using System.Linq;

namespace TestMaximumProblem
{
   public class  TestMaximumInteger
    {
        public T maxValueArray<T>(T number1, T number2, T number3)
        {
            T[] maxNumber = { number1, number2, number3 };
            //Finding The Maximum double In Array
            T MaxValue = maxNumber.Max();
            return MaxValue;
        }
        public static void Main(String[] args)
        {
            TestMaximumInteger tm = new TestMaximumInteger();

        }
    }
}
