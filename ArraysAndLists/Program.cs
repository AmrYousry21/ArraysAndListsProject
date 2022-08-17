using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[11];

            for (int i = 1; i < numbers.Length; i++) 
            {
                numbers[i] = i;
            }

            List<int> evens = new List<int>();
            List<int> odds = new List<int>();
           

            foreach (int i in numbers) 
            {
                if (i % 2 == 0 && i != 0) 
                {
                    evens.Add(i);
                }
                if (i % 2 != 0 && i != 0)
                {
                    odds.Add(i);
                }
            }
            Console.WriteLine("Number in evens List: \n");
            foreach(int i in evens) 
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine();

            Console.WriteLine("Number in odds List: \n");
            foreach (int i in odds)
            {
                Console.WriteLine(i);
            }

        }
    }
}
