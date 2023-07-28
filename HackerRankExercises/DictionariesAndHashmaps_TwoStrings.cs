using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExercises
{
    class DictionariesAndHashmaps_TwoStrings
    {
        public static void DictionariesAndHashmaps_TwoStringsExercise()
        {
            string retVal = twoStrings("hello", "world");
            Console.WriteLine("Do String1 and String2 share a substring?  " + retVal);
            retVal = twoStrings("hi", "world");
            Console.WriteLine("Do String1 and String2 share a substring?  " + retVal);
        }

        private static string twoStrings(string s1, string s2)
        {
            HashSet<char> hs1 = new HashSet<char>();
            for (int i = 0; i < s1.Length; i++)
            {
                hs1.Add(s1[i]);
            }

            HashSet<char> hs2 = new HashSet<char>();
            for (int i = 0; i < s2.Length; i++)
            {
                hs2.Add(s2[i]);
            }
            hs1.IntersectWith(hs2);

            return (hs1.Count > 0) ? "YES" : "NO";
        }
    }
}
