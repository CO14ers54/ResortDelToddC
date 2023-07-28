using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExercises
{
    class DynamicProgramming_CandiesExercise
    {
        public static void DynamicProgramming_Candies()
        {
            //int classSize = 10;
            //int[] rating = { 2, 4, 2, 6, 1, 7, 8, 9, 2, 1 };
            int classSize = 8;
            int[] rating = { 2, 4, 3, 5, 2, 6, 4, 5};

            int minNumCandies = MinimumCandies(classSize, rating);

            Console.WriteLine("The minimum number of candies is: " + minNumCandies);
        }

        private static int MinimumCandies(int classSize, int[] arrRank)
        {
            int numCandies = classSize;

            for (int i = 0; i < classSize; i++)
            {
                if ( ((i+1) < classSize) && (arrRank[i+1] > arrRank[i]) )
                {
                    Console.WriteLine("i = " + i + ". Giving more candy to the student on the right.");
                    numCandies++;
                }

                if (((i - 1) >= 0) && (arrRank[i-1] > arrRank[i]) )
                {
                    Console.WriteLine("i = " + i + ". Giving more candy to the student on the left.");
                    numCandies++;
                }
            }


            return numCandies;
        }
    }
}
