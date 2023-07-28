using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExercises
{
   class Arrays_ArraysDS
   {
      public static void Arrays_ArraysDS_Exercise()
      {
         int[] origArray = {1,4,3,2};

         int[] revArray = ReverseArray(origArray);

         StringBuilder sb = new StringBuilder();
         foreach (int n in revArray)
         {
            sb.Append(n + " ");
         }

         Console.WriteLine(sb.ToString().TrimEnd());
      }

      private static int[] ReverseArray(int[] origArray)
      {
         List<int> list = new System.Collections.Generic.List<int>();

         for (int i = origArray.Length - 1; i >=  0; i--)
         {
            list.Add(origArray[i]);
         }
         
         return list.ToArray();
      }
   }
}
