using System;
using System.Linq;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string[] TEMPS = Console.ReadLine().Split(' '); // the N temperatures expressed as integers ranging from -273 to 5526
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        int[] intTEMPS = new int[N];
        List<int> neg = new List<int>();
        List<int> pos = new List<int>();

        for (int i = 0; i < N; i++)
        {
            intTEMPS[i] = Convert.ToInt32(TEMPS[i]);
        }

        if (N == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            for (int i = 0; i < N; i++)
            {
                if (intTEMPS[i] > 0)
                    pos.Add(intTEMPS[i]);
                else
                    neg.Add(intTEMPS[i]);
            }
            if (pos.Count == 0 && neg.Count != 0)
                Console.WriteLine(neg.Max());
            else if (pos.Count != 0 && neg.Count == 0)
                Console.WriteLine(pos.Min());

            else
            {
                if (pos.Min() == -neg.Max())
                    Console.WriteLine(pos.Min());
                else if (pos.Min() < -neg.Max())
                    Console.WriteLine(pos.Min());
                else if (pos.Min() > -neg.Max())
                    Console.WriteLine(neg.Max());
            }
        }
    }
}