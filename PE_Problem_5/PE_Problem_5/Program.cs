using System;


// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?


namespace PE_Problem_5
{
    internal class Program
    {
        // 0 at the end guarantees even division by 2, 5 and 10

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (long i = 10; i < 349188840; i++)
            {
                if ((i.ToString()[^1] == '0') && (i % 3 == 0) && (i % 4 == 0) && (i % 6 == 0) && (i % 7 == 0) && (i % 8 == 0) && (i % 9 == 0) && (i % 11 == 0) && (i % 12 ==0)
                    && (i % 13 == 0) && (i % 14 == 0) && (i %15 == 0) && (i % 16 ==0)
                    && (i % 17 == 0) && (i % 18 ==0) && (i % 19 ==0) )
                {
                    Console.WriteLine("{0} ", i);
                }
            }

        }
    }
}
