using System;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print TX and TY, if Thor does not follow your orders.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int LX = int.Parse(inputs[0]); // the X position of the light of power
        int LY = int.Parse(inputs[1]); // the Y position of the light of power
        int TX = int.Parse(inputs[2]); // Thor's starting X position
        int TY = int.Parse(inputs[3]); // Thor's starting Y position

        // game loop
        while (true)
        {
            int E = int.Parse(Console.ReadLine()); // The level of Thor's remaining energy, representing the number of moves he can still make.

            int dx = 0;
            int dy = 0;

            if (LX < TX)
                dx = -1;
            else if (LX > TX)
                dx = 1;

            if (LY < TY)
                dy = -1;
            else if (LY > TY)
                dy = 1;

            if (dy == -1)
            {
                if (dx == -1)
                    Console.WriteLine("NW");
                else if (dx == 1)
                    Console.WriteLine("NE");
                else
                    Console.WriteLine("N");
            }
            else if (dy == 1)
            {
                if (dx == -1)
                    Console.WriteLine("SW");
                else if (dx == 1)
                    Console.WriteLine("SE");
                else
                    Console.WriteLine("S");
            }
            else
            {
                if (dx == -1)
                    Console.WriteLine("W");
                else if (dx == 1)
                    Console.WriteLine("E");
            }
            TX += dx;
            TY += dy;
        }
    }
}