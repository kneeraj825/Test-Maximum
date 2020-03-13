using System;

namespace TestMaximumProblem
{
   public class  TestMaximumInteger
    {
        public int maximumInteger(int firstValue, int secondValue, int thirdValue)
        {

            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            else if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            else
            {
                return 0;
            }
        }

        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Test Maximum Problem");
            TestMaximumInteger testmaximuminteger = new TestMaximumInteger();
        }
    }
}
