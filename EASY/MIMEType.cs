using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
        int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
        Dictionary<string, string> d = new Dictionary<string, string>(
            StringComparer.OrdinalIgnoreCase);  //Ignore case while checking keys

        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            d.Add(inputs[0], inputs[1]);         //Add to dictionary
        }

        for (int i = 0; i < Q; i++)
        {
            string FNAME = Console.ReadLine(); // One file name per line.
            int index = FNAME.LastIndexOf('.'); //Check the first occurence of string or char
                                                //from the end

            int flag = -1;
            if (index != -1)
            {
                if (d.ContainsKey(FNAME.Substring(index + 1)))
                {
                    string value = d[FNAME.Substring(index + 1)]; // returns value to the searched key
                    Console.WriteLine(value);
                    flag = 1;
                }
            }

            if (flag == -1)
            {
                Console.WriteLine("UNKNOWN");
            }
        }
    }
}