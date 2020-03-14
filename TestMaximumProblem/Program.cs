using System;
using System.Linq;

namespace TestMaximumProblem
{
    
    public class Test
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Test Maximum Problem");
        }
        public class TestMaximumValue<E>
        {
            E variable1;
            E variable2;
            E variable3;
            public TestMaximumValue(E variable1, E variable2, E variable3)
            {
                this.variable1 = variable1;
                this.variable2 = variable2;
                this.variable3 = variable3;

            }
            public E TestMaximum()
            {
                return maxValueArray(this.variable1, this.variable2, this.variable3);
            }
            public static T maxValueArray<T>(T number1, T number2, T number3)
            {
                T[] maxNumber = { number1, number2, number3 };
                //Finding The Maximum value In Array
                T MaxValue = maxNumber.Max();
                Console.WriteLine(MaxValue);
                return MaxValue;
            }
        } 
    }
}
