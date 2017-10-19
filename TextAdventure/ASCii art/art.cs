using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventure.ASCii_art
{
    class art
    {
        public static void RobotArt()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Title = "ASCII Art";
            string title = @"
                    +-------------+
                    +-------------+
                    | |   ||    | |
                    | +---------+ |
                    | |---------| |
                    | |---------| |
                  +-+-------------+--+
+-----------------+                  +-----------------+
|                 |                  |                 |
|                 |                  |                 |
|                 |                  |                 |
+-----------------+                  +-----------------+
                  |                  |
                  |                  |
                  |                  |
                  |                  |
                  |                  |
                  |                  |
                  |                  |
                +-+-----+-------+----+--+
                |       |       |       |
                |       |       |       |
                |       |       |       |
                |       |       |       |
                |       |       |       |
                |       |       |       |
                |       |       |       |
                |       |       |       |
                +-------+       +-------+
                       ";

            Console.WriteLine(title);
            Console.WriteLine("Press Enter To Start!");
            Console.Read();
        }
    }
}

