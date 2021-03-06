﻿using System;
using System.Collections.Generic;
using System.Linq;
class SortedSubsetSums
{
    static void Main()
    {
        // input
        Console.Write("Enter sum = ");
        int sum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter numbers separated by a space:");
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        // remove duplicates
        List<int> noDuplicates = numbers.ToList();
        noDuplicates = noDuplicates.Distinct().ToList();
        // generate subsets
        var subsets = from m in Enumerable.Range(0, 1 << noDuplicates.Count)
                      select
                          from i in Enumerable.Range(0, noDuplicates.Count)
                          where (m & (1 << i)) != 0
                          select noDuplicates[i];
        // check subsets' sums and add them to a list
        bool noOutput = true;
        Console.WriteLine("Output:");
        List<List<int>> subsetsSort = new List<List<int>>();
        foreach (var item in subsets)
        {
            int sumTemp = 0;
            List<int> tempList = new List<int>();
            foreach (var number in item)
            {
                sumTemp += Convert.ToInt32(number);
            }
            if (sumTemp == sum && item.Count() > 0)
            {
                subsetsSort.Add(item.ToList());
                noOutput = false;
            }
        }
        // sort list of lists
        foreach (var item in subsetsSort)
        {
            item.Sort();
        }
        subsetsSort = subsetsSort.OrderBy(p => p.Count).ThenBy(p => p[0]).ToList();
        foreach (var item in subsetsSort)
        {
            Console.WriteLine(string.Join(" + ", item) + " = {0}", sum);
        }
        if (noOutput)
            Console.WriteLine("No matching subsets.");
    }
}
