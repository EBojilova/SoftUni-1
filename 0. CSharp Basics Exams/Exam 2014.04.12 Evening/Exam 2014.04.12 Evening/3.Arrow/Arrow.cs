﻿using System;
class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{0}", new string('.', (n - 1) / 2), new string('#', n));
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('.', (n - 1) / 2), new string('.', n - 2));
        }
        Console.WriteLine("{0}{1}{0}", new string('#', (n - 1) / 2 + 1), new string('.', n - 2));
        for (int i = 1; i <= n - 2; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('.', i), new string('.', 2 * n - 1 - 2 * (i + 1)));
        }
        Console.WriteLine("{0}#{0}", new string('.', n - 1));
    }
}
