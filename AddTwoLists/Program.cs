using System;
using System.Collections.Generic;
using System.Linq;

namespace AddTwoLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<int> { 1, 2, 5, 4 };
            var list2 = new List<int> { 2, 4, 6, 8, 10 };
            List<int> totals = new List<int>();

            List<int> longest = new List<int>();
            List<int> shortest = new List<int>();

            if (list1.Count > list2.Count)
            {
                longest = list1;
                shortest = list2;
            }
            else
            {
                longest = list2;
                shortest = list1;
            }

            for (int i = 0; i < longest.Count; i++)
            {
                if (i < shortest.Count)
                {
                    totals.Add(longest[i] + shortest[i]);
                }
                else
                {
                    totals.Add(longest[i]);
                }
            }

            foreach (int num in totals)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();

        }
    }
}