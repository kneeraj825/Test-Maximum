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
        public int isIntegerArray(int number1, int number2, int number3)
        {
            int[] integerNumber = { number1, number2, number3 };
            //Finding The Maximum integer In Array
            int MaxValue = integerNumber.Max();
            return MaxValue;
        }
        public int isStringArray(String first, String second, String third)
        {
            int str1 = first.Length;
            int str2 = second.Length;
            int str3 = third.Length;
            //Finding The Maximum integer In Array
            int[] StringArray = { str1, str2, str3 };
            int MaxValue = StringArray.Max();
            return MaxValue;
        }
        public static void Main(String[] args)
        {
            TestMaximumInteger tm = new TestMaximumInteger();

        }
    }
}
