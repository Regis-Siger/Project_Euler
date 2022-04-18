using System;
using System.Collections.Generic;
using System.Linq;

namespace PE_Problem_4
{

    internal class Program
    {
        public static List<string> GenerateListOfStrings()
        {
            List<string> list = new List<string>();
            int result;
            for (int i = 100; i < 999; i++)
            {
                for (int j = 100; j < 999; j++)
                {
                    result = i * j;
                    list.Add(result.ToString());
                }
            }
            return list;
        }
        public static string Reverse(string result)
        {
            string reversed = "";
            for (int i = 0; i < result.Length; i++)
            {
                reversed += result[result.Length - 1 - i];
            }
            return reversed;
        }
        public static List<int> FindPalindromes(List<string> list)
        {
            List<int> palindromes = new List<int>();
            foreach (string i in list)
            {
                if (i == Reverse(i))
                {
                    palindromes.Add(Int32.Parse(i));
                }
            }
            return palindromes;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindPalindromes(GenerateListOfStrings()).Max()); 
        }
    }
}
