using System;
using System.Collections.Generic;
using System.Linq;

//The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
//Find the sum of all the primes below two million.
//--------------------------
// Make a list of all the integers less than or equal to n (greater than one) and strike out the multiples of all primes
// less than or equal to the square root of n, then the numbers that are left are the primes.
// For example, to find all the odd primes less than or equal to 100 we first list the odd numbers from 3 to 100
// The first number is 3 so it is the first odd prime--cross out all of its multiples.
// Now the first number left is 5, the second odd prime--cross out all of its multiples.
// Repeat with 7 and then since the first number left, 11, is larger than the square root of 100, all of the numbers left are primes

namespace PE_Problem_10
{
    class Primes
    {
        List<double> _primes = new List<double> { 2 };
        double _ceiling;
        List<double> ListOfOdds()
        {
            for (int i = 2; i <= _ceiling; i++)
            {
                if (i % 2 != 0) _primes.Add(i);
            }
            return _primes;
        }
        List<double> FindPrimes()
        {
            int i = 1;
            do
            {
                double prime = _primes[i];
                _primes.RemoveAll(x => x!=prime && x%prime==0);
                i++;
            } while (_primes[i] < Math.Sqrt(_ceiling));
            return _primes;
        }
        public Primes(double ceiling)
        {
            _ceiling = ceiling;
            ListOfOdds();
            FindPrimes();
        }
        public double SumAll()
        {
            double sum = 0;
            _primes.ForEach(x => sum += x);
            return sum;
        }
        public void PrintN(int n)
        {
            Console.WriteLine("First {0} primes on a list are: \n",n);
            for (int i = 0; i < n; i++)
            {
                Console.Write(_primes[i] + " ");
            }
        }
        public double Max()
        {
            return _primes.Max();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the max value below which you want the prime numbers to be summed up: \n");
            double value = double.Parse(Console.ReadLine());
            Primes primes = new Primes(value);
            Console.WriteLine("The sum of all the primes below {0} is: {1}", value, primes.SumAll());
            Console.WriteLine("Highest prime on a list is: {0}", primes.Max());
            Console.WriteLine("How many primes you want me to print out?\n");
            int howMany = int.Parse(Console.ReadLine());
            primes.PrintN(howMany);

            Console.ReadLine();
        }
    }
}
