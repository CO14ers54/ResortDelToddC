using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HackerRankExercises
{
    class RepeatedStringExercise
    {

        public static void RepeatedString()
        {
            string s = "aba";
            long n = 10;

            //string s = "a";
            //long n = 1000000000000;

            long result = RepeatedString(s, n);
            Console.WriteLine("The count of 'a' is: " + result.ToString());
        }

        private static long RepeatedString(string s, long n)
        {
            long lenSubStr = s.Length;
            long occurencesOfAInSubstring = s.Split('a').Length - 1;

            long numWholeSubStrings = n / lenSubStr;
            long occurencesOfAInString = numWholeSubStrings * occurencesOfAInSubstring;
            long remainder = n % lenSubStr;

            long occurencesOfAInRemainder = s.Substring(0, (int)remainder).Split('a').Length - 1;
            occurencesOfAInString += occurencesOfAInRemainder;

            Console.WriteLine("lenSubStr = " + lenSubStr);
            Console.WriteLine("numWholeSubStrings = " + numWholeSubStrings);
            Console.WriteLine("remainder = " + remainder);

            return occurencesOfAInString;
        }
    }
}
