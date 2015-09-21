using System;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(string[] args)
    {
        int R = int.Parse(Console.ReadLine()); // the length of the road before the gap.
        int G = int.Parse(Console.ReadLine()); // the length of the gap.
        int L = int.Parse(Console.ReadLine()); // the length of the landing platform.

        // game loop
        while (true)
        {
            int S = int.Parse(Console.ReadLine()); // the motorbike's speed.
            int X = int.Parse(Console.ReadLine()); // the position on the road of the motorbike.
                                                   // Write an action using Console.WriteLine()
                                                   // To debug: Console.Error.WriteLine("Debug messages...");

            // A single line containing one of 4 keywords: SPEED, SLOW, JUMP, WAIT.
            if (X >= R - S && S == G + 1 && X < R)
                Console.WriteLine("JUMP");
            else if (S == G + 1 && X <= R)
                Console.WriteLine("WAIT");
            else if (X < R && S < G + 1)
                Console.WriteLine("SPEED");
            else if (X >= R || S > G + 1)
                Console.WriteLine("SLOW");

            Console.Error.WriteLine("x:" + X + "r: " + R + "g: " + G);
        }
    }
}