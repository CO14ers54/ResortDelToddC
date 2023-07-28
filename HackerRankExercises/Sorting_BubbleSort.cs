using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExercises
{
   class Sorting_BubbleSort
   {
      public static void Sorting_BubbleSort_Exercise()
      {
         //int[] a = { 1, 2, 3 };
         int[] a = { 3, 2, 1 };

         CountSwaps(a);
      }

      private static void CountSwaps(int[] a)
      {
         int n = a.Length;
         int swapCounter = 0;
         int temp;
         for (int i = 0; i < n; i++)
         {

            for (int j = 0; j < n - 1; j++)
            {
               // Swap adjacent elements if they are in decreasing order
               if (a[j] > a[j + 1])
               {
                  temp = a[j + 1];
                  a[j + 1] = a[j];
                  a[j] = temp;
                  swapCounter++;
                  //swap(a[j], a[j + 1]);
               }
            }
         }
         Console.WriteLine("Array is sorted in " + swapCounter + " swaps.");
         Console.WriteLine("First Element: " + a[0]);
         Console.WriteLine("Last Element: " + a[n - 1]);

      }
   }
}
