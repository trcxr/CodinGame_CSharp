using System;
using System.Linq;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(string[] args)
    {

        // game loop
        while (true)
        {
            int[] mo = new int[8];
            string[] inputs = Console.ReadLine().Split(' ');
            int SX = int.Parse(inputs[0]);
            int SY = int.Parse(inputs[1]);
            for (int i = 0; i < 8; i++)
            {
                int MH = int.Parse(Console.ReadLine()); // represents the height of one mountain, from 9 to 0. Mountain heights are provided from left to right.
                mo[i] = MH;
                // Console.Error.WriteLine("MH : "+MH);
            }

            // Console.Error.WriteLine("SX : "+SX;
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            if (mo[SX] > 0 && mo[SX] >= mo.Max())
                Console.WriteLine("FIRE"); // either:  FIRE (ship is firing its phase cannons) or HOLD (ship is not firing).
            else
                Console.WriteLine("HOLD");
            SX++;
        }
    }
}