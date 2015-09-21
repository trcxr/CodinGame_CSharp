using System;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine();

        for (int i = 0; i < H; i++)
        {
            string ROW = Console.ReadLine();
            for (int j = 0; j < T.Length; j++)
            {
                char ch = T[j];
                if (Char.IsLetter(ch))
                {
                    ch = Char.ToUpper(ch);
                    int A = (int)ch;
                    int newA = A - 64;
                    for (int x = (newA - 1) * L; x < newA * L; x++)
                        Console.Write(ROW[x]);
                }
                else
                {
                    int newA = L * 27;
                    for (int x = newA - (1 * L); x < newA; x++)
                        Console.Write(ROW[x]);
                }
            }
            Console.WriteLine();
        }
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
    }
}