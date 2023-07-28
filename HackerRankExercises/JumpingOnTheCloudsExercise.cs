using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExercises
{
    class JumpingOnTheCloudsExercise
    {
        public static void JumpingOnTheClouds()
        {
            int[] cloudArray = { 0, 1, 0, 0, 0, 1, 0 };

            int minJumps = JumpingOnTheClouds(cloudArray);
            Console.WriteLine("Minimum Jumps = " + minJumps);
        }

        static int JumpingOnTheClouds(int[] cloudArray)
        {
            int i = 0;
            int jumps = 0;
            while (i < cloudArray.Length)
            {
                if ( ((i + 2) < cloudArray.Length) && (cloudArray[i + 2] == 0) )
                {
                    Console.WriteLine("Double Jumping!!!  i = " + i);
                    jumps += 1;
                    i = i + 2;
                    Console.WriteLine("Resetting  i = " + i);
                    continue;
                }
                else if (((i + 1) < cloudArray.Length) && (cloudArray[i + 1]) == 0)
                {
                    Console.WriteLine("Single Jumping.  i = " + i);
                    jumps += 1;
                    i = i + 1;
                    Console.WriteLine("Resetting  i = " + i);
                    continue;
                }
                else
                {
                    Console.WriteLine("Cannot move anymore.  i = " + i);
                    // can't move
                    break;
                }
            }

            return jumps;
        }
    }
}
