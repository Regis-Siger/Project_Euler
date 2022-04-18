using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The sum of the squares of the first ten natural numbers is 1^2+2^2+...+10^2 = 385
// The square of the sum of the first ten natural numbers is (1+2+...+10)^2=55^2 = 3025
// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 - 385 = 2640
// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

namespace PE_Problem_6
{
    internal class Program
    {
        public static int SumOfSqrs(int begin, int end)
        {
            int result = 0;
            for (int i = begin; i <= end; i++)
            {
                result += i * i;
            }
            return result;
        }
        public static int SqrOfSum(int begin, int end)
        {
            int result = 0;
            for (int i = begin; i <= end; i++)
            {
                result += i;
            }
            result *= result;
            return result;
        }
        static void Main(string[] args)
        {
            int begin = 1;
            int end = 100;
            Console.WriteLine("Sum of the squares: ");
            Console.WriteLine(SumOfSqrs(begin, end));
            Console.WriteLine("Square of the sum: ");
            Console.WriteLine(SqrOfSum(begin,end));
            Console.WriteLine("The difference is: ");
            Console.WriteLine(SqrOfSum(begin,end)-SumOfSqrs(begin,end));
            Console.ReadLine();
        }
    }
}
