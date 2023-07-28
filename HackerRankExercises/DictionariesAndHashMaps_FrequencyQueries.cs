using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExercises
{
   class DictionariesAndHashMaps_FrequencyQueries
   {
      public static void DictionariesAndHashMaps_FrequencyQueries_Exercise()
      {
         /*
         List<List<int>> queries = new List<List<int>>() {
            new List<int>(){1,5},
            new List<int>(){1,6},
            new List<int>(){3,2},
            new List<int>(){1,10},
            new List<int>(){1,10},
            new List<int>(){1,6},
            new List<int>(){2,5},
            new List<int>(){3,2}
         };
         */
         /*
         List<List<int>> queries = new List<List<int>>() {
            new List<int>(){3,4},
            new List<int>(){2,1003},
            new List<int>(){1,16},
            new List<int>(){3,1}
         };
         */
         
         List<List<int>> queries = new List<List<int>>() {
            new List<int>(){1,3},
            new List<int>(){2,3},
            new List<int>(){3,2},
            new List<int>(){1,4},
            new List<int>(){1,5},
            new List<int>(){1,5},
            new List<int>(){1,4},
            new List<int>(){3,2},
            new List<int>(){2,4},
            new List<int>(){3,2}
         };
         

         List<int> results = FrequencyQuery(queries);

         foreach(int i in results)
         {
            Console.WriteLine(i);
         }

      }

      private static List<int> FrequencyQuery(List<List<int>> queries)
      {
         List<int> result = new List<int>();
         Dictionary<int, int> dict = new Dictionary<int, int>();

         foreach (var query in queries)
         {
            if (query[0] == 1) // query 1
            {
               if (!dict.ContainsKey(query[1]))
               {
                  dict.Add(query[1], 1);
               }
               else
               {
                  dict[query[1]] += 1;
               }
            }
            else if (query[0] == 2)
            {
               if (dict.ContainsKey(query[1]))
               {
                  dict[query[1]] -= 1;

                  if (dict[query[1]] == 0)
                  {
                     dict.Remove(query[1]);
                  }
               }
            }
            else
            {
               int count = 0;
               foreach (var key in dict.Keys) 
               {
                  if (dict[key] == query[1])
                  {
                     count++;
                     result.Add(1);
                     break;
                  }
               }
               if (count == 0)
               {
                  result.Add(0);
               }
            }
         }

         return result;
      }
   }
}
