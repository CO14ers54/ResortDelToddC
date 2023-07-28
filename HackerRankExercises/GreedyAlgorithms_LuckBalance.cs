using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExercises
{
   class GreedyAlgorithms_LuckBalance
   {
      public static void GreedyAlgorithms_LuckBalance_Exercise()
      {
         int k = 1;
         //int[][] constests = new int[3][2]{{5, 1},{1, 1 },{4, 0 }};

         //int luckBalance = LuckBalance(k, contests);

         //Console.WriteLine("The amount of luck acculated is: " + luckBalance);
      }

      private static int LuckBalance(int k, int[][]contests)
      {
         var minLosses = contests
            .Where(x => x[1] == 1)
            .OrderByDescending(x => x[0])
            .Skip(k)
            .Sum(x => x[0]);

         var totalVal = contests.Sum(x => x[0]);

         return totalVal - (minLosses * 2);
      }
   }
}
