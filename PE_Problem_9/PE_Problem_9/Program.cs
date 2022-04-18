using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_Problem_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int c = 0; c < 500; c++)
            {
                for (int b = 0; b < 500; b++)
                {
                    for (int a = 0; a < 500; a++)
                    {
                        if ((a+b+c==1000) && (a*a + b*b == c * c))
                        {
                            list.Add(c);
                            list.Add(b);
                            list.Add(a);
                        }
                    }
                }

            }
            list.Distinct().ToList().ForEach(x => Console.Write("{0} ",x));
            Console.WriteLine("\nThe product is: \n");
            int product=1;
            foreach (int x in list.Distinct()) product *= x;
            Console.WriteLine(product);
            Console.ReadLine();
        }
    }
}
