using System;
using System.Collections.Generic;

namespace CSharp_Features_Delegates_Simple
{
    public delegate bool MyDelegate(int n);

    class Program
    {

        static bool LessThanFive(int n)
        {
            return n < 5;
        }
        static bool LessThanTen(int n)
        {
            return n < 10;
        }
        static bool GreaterThanThirteen(int n)
        {
            return n > 13;
        }
        static void Main(string[] args)
        {
            int[] numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            IEnumerable<int> result = RunNumbersThroughGauntlet(numbers, GreaterThanThirteen); // This basically parameterizes the function you want to use!

            foreach(int n in result)
            {
                Console.WriteLine(n);
            }
        }

        static IEnumerable<int> RunNumbersThroughGauntlet(IEnumerable<int> numbers, MyDelegate gauntlet)
        {
            foreach (int number in numbers)
            {
                if (gauntlet(number))
                {
                    yield return number; // You use a yield return statement to return each element one at a time.
                }
            }
        }
    }
}
