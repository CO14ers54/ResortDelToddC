using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExercises
{
    class CountingValleysExercise
    {

        public static void CountingValleys()
        {
            int steps = 8;
            string path = "UDDDUDUU";

            int numValleys = CountingValleys(steps, path);

            Console.WriteLine("Number of valleys during the hike is: " + numValleys);
        }

        private static int CountingValleys(int steps, string path)
        {
            int numValleys = 0;
            int altitude = 0;  // 0 = sea level, > 0 = above sea level, < 0 = below sea level
            bool inValley = false;

            Console.WriteLine("Altitude is: " + altitude);

            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == 'U')
                {
                    Console.WriteLine("Uphill Step");
                    if (altitude == 0)
                    {
                        Console.WriteLine("Was at sea level, now on a mountain");
                        if (inValley)
                        {
                            inValley = false;
                        }
                    }
                    altitude += 1;
                    Console.WriteLine("Altitude is: " + altitude);
                }
                else
                {
                    Console.WriteLine("Downhill Step");

                    if (altitude == 0)
                    {
                        Console.WriteLine("Was at sea level, now in a valley");
                        inValley = true;
                        numValleys += 1;
                    }
                    altitude -= 1;
                    Console.WriteLine("Altitude is: " + altitude);
                }
            }

            return numValleys;
        }
    }
}
