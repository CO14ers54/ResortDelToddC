using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
   class RemoveArrayElementsProblem
   {
      public static void RemoveArrayElements()
      {
         //int[] ary = new int[] { 3, 2, 2, 3 };
         int[] ary = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
         //int[] ary = new int[] { 1, 2, 2, 2, 2, 2, 2, 3 };
         //int val = 3;
         int val = 2;
         int size = RemoveArrayElements(ary, val);

         StringBuilder sb = new StringBuilder();

         sb.Append("The array now = [");
         for (int i = 0; i < size; i++)
         {
            sb.Append(ary[i] + ",");
         }
         Console.WriteLine(sb.ToString());

         Console.WriteLine("The new size of the array is: " + size);
      }

      private static int RemoveArrayElements(int[] nums, int val)
      {
         int count = 0;
         for (int i = 0; i < nums.Length; i++)
         {
            if (nums[i] != val)
            {
               nums[count] = nums[i];
               count++;
            }
         }

         return count;
      }
   }
}
