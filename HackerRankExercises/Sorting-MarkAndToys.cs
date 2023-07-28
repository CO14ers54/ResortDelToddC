using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRankExercises
{
   class Sorting_MarkAndToys
   {
      public static void Sorting_MarkAndToysExercise()
      {
         int[] prices = {1,12,5,111,200,1000,10};
         int budget = 50;

         int numberOfToys = MaximumToys(prices, budget);
         Console.WriteLine(numberOfToys);
      }

      private static int MaximumToys(int[] prices, int budget)
      {
         List<int> sortedPriceList = prices.ToList();
         sortedPriceList.Sort();

         int sum = 0;
         int numberOfToys = 0;
         foreach( int price in sortedPriceList )
         {
            if (sum + price > budget)
            {
               break;
            }
            sum += price;
            numberOfToys++;
         }
         return numberOfToys;
      }
   }
}
