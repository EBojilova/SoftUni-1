﻿// Assume that repeating the same subset several times is not a problem. 
using System;
class ZeroSubset
{
    static void Main()
    {
    Start:
        Console.Write("Enter 5 integers separated by space: ");
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = new int[5];
        bool noOutput = true;
        int sum = 0;
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = int.Parse(input[i]);
            sum += numbers[i];
        }
        for (int a = 0; a < 5; a++)
        {
            for (int b = 0; b < 5; b++)
            {
                for (int c = 0; c < 5; c++)
                {
                    for (int d = 0; d < 5; d++)
                    {
                        for (int e = 0; e < 5; e++)
                        {
                            if (a != b && a != c && a != d && a != e &&
                                b != c && b != d && b != e &&
                                c != d && c != e && d != e)
                            {
                                if (sum - numbers[a] == 0)
                                {
                                    Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbers[b], numbers[c], numbers[d],
                                        numbers[e]);
                                    noOutput = false;
                                }
                                else if (sum - numbers[a] - numbers[b] == 0)
                                {
                                    Console.WriteLine("{0} + {1} + {2} = 0", numbers[c], numbers[d], numbers[e]);
                                    noOutput = false;
                                }
                                else if (sum - numbers[a] - numbers[b] - numbers[c] == 0)
                                {
                                    Console.WriteLine("{0} + {1} = 0", numbers[d], numbers[e]);
                                    noOutput = false;
                                }
                            }
                        }
                    }
                }
            }
        }
        if (noOutput)
        {
            Console.WriteLine("no zero subset");
        }
        goto Start;
    }
}
