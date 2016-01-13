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
        bool prevOne = true;
        bool prevZero = true;
        int one = 0;
        int zero = 0;
        string output = "";
        string dummy = "";
        string MESSAGE = Console.ReadLine();


        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        for (int i = 0; i <= MESSAGE.Length; i++)
        {
            if (i == MESSAGE.Length)
            {
                if (one > 0)
                {
                    for (int x = 0; x < one; x++)
                        dummy += "0";

                    output += "0 " + dummy;
                }
                else if (zero > 0)
                {
                    for (int x = 0; x < zero; x++)
                        dummy += "0";

                    output += "00 " + dummy;
                }

            }
            else
            {
                string binaryCharCode = Convert.ToString(MESSAGE[i], 2);

                while (binaryCharCode.Length < 7)
                {
                    binaryCharCode = "0" + binaryCharCode;
                }

                for (int j = 0; j < binaryCharCode.Length; j++)
                {

                    if (binaryCharCode[j] == '1' && prevOne)
                    {
                        one++;
                        prevOne = true;
                        prevZero = false;
                    }
                    else if (binaryCharCode[j] == '0' && prevZero)
                    {
                        zero++;
                        prevZero = true;
                        prevOne = false;
                    }
                    else if (binaryCharCode[j] == '1' && !prevOne)
                    {
                        for (int x = 0; x < zero; x++)
                            dummy += "0";

                        output += "00 " + dummy + " ";
                        dummy = "";
                        zero = 0;
                        one++;
                        prevOne = true;
                        prevZero = false;
                    }
                    else if (binaryCharCode[j] == '0' && !prevZero)
                    {
                        for (int x = 0; x < one; x++)
                            dummy += "0";

                        output += "0 " + dummy + " ";
                        dummy = "";
                        one = 0;
                        zero++;
                        prevOne = false;
                        prevZero = true;
                    }
                }
            }
        }
        Console.WriteLine(output);
    }
}