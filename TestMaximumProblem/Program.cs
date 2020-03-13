using System;

namespace TestMaximumProblem
{
   public class  TestMaximumInteger
    {
        public void maximumInteger()
        {
            //taking input from user
            Console.WriteLine("Enter the first number:");
            int firstValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(firstValue);
            Console.WriteLine("Enter the second number:");
            int secondValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(secondValue);
            Console.WriteLine("Enter the third number:");
            int thirdValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(thirdValue);
            //comparing the two value
            int firstValuesecondValue = firstValue.CompareTo(secondValue);
            int secondValuethirdvalue = secondValue.CompareTo(thirdValue);
            int firstValuethirdValue = firstValue.CompareTo(thirdValue);
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                Console.WriteLine(firstValue + " is greatest");
            }
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                Console.WriteLine(secondValue + " is greatest");
            }
            else if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                Console.WriteLine(thirdValue + " is greatest");
            }
            else
            {
                Console.WriteLine("invalid number");
            }
        }
    
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Test Maximum Problem");
            TestMaximumInteger testmaximuminteger = new TestMaximumInteger();
            testmaximuminteger.maximumInteger();
        }
   }
}
