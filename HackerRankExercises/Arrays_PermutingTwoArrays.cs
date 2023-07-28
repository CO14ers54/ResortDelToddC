using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExercises
{
   class Arrays_PermutingTwoArrays
   {
      public static void Arrays_PermutingTwoArrays_Exercise()
      {
         StringBuilder sb = new StringBuilder();

         int[] a = new int[3] { 2, 1, 3 };
         int[] b = new int[3] { 7, 8, 9 };
         sb.Append(twoArrays(10, a, b) + "\n");

         int[] c = new int[4] { 1, 2, 2, 1 };
         int[] d = new int[4] { 3, 3, 3, 4 };
         sb.Append(twoArrays(5, c, d) + "\n");

         Console.WriteLine(sb.ToString());
      }

      private static string twoArrays(int k, int[] a, int[] b)
      {
         List<int> aList = new List<int>(a);
         List<int> bList = new List<int>(b);
         aList.Sort();
         bList.Sort();

         string result = string.Empty;

         int count = aList.Count;
         bool success = true;
         for (int i = 0; i < count; i++)
         {
            if (aList[i] + bList[(count - 1) - i] < k )
            {
               success = false;
               break;
            }
         }

         if (success == true)
         {
            result = "YES";
         }
         else
         {
            result = "NO";
         }

         return result;
      }
   }
}
