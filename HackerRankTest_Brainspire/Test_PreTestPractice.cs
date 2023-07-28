using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTest_Brainspire
{
   class Test_PreTestPractice
   {
      public static void Test_PreTestPractice_FizzBuzz()
      {
         FizzBuzz(15);
      }

      private static void FizzBuzz(int n)
      {
         for (int i = 1; i <= n; i++)
         {
            if ((i % 5 == 0) && (i % 3 == 0))
            {
               Console.WriteLine("FizzBuzz");
            }
            else if ((i % 5 != 0) && (i % 3 == 0))
            {
               Console.WriteLine("Fizz");
            }
            else if ((i % 5 == 0) && (i % 3 != 0))
            {
               Console.WriteLine("Buzz");
            }
            else
            {
               Console.WriteLine(i);
            }
         }
      }
   }
}
