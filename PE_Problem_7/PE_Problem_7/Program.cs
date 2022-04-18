using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
// What is the 10 001st prime number?

namespace PE_Problem_7
{
    internal class Program
    {
        public static List<int> ValidationForPrimes(List<int> list)
        {
            List<int> primes = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                primes.Add(list[i]);
            }
            for (int i = 4; i < list.Count; i++)
            {
                for (int j = 1; j < list.Count; j++)
                {
                    if (list[i]!=list[j] && (list[i] % list[j])==0)
                    {
                        int delete = list[i];
                        primes.Remove(delete);
                    }
                }
            }
            return primes;
        }
        static void Main(string[] args)
        {
            List<int> primesCandidates = new List<int>() {2,3,5,7};
            for (int i = 2; i < 25000; i++)
            {
                primesCandidates.Add((i*6)-1);
                primesCandidates.Add((i*6)+1);
            }
            //ValidationForPrimes(primesCandidates).ForEach(x => Console.Write("{0} ",x));
            //Console.WriteLine("\nCount: " + ValidationForPrimes(primesCandidates).Count);
            
            Console.WriteLine("Prime number no 10001 is: {0}",ValidationForPrimes(primesCandidates)[10000]);
            
            // the answer is 104743, calculated in 43 sec

            Console.ReadLine();
        }
    }
}
