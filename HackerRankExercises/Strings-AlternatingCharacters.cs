using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExercises
{
    class Strings_AlternatingCharacters
    {
        public static void Strings_AlternatingCharactersExercise()
        {
            string s = "AAAA";

            int deletions = AlternatingCharacters(s);
            Console.WriteLine("Deletions: " + deletions);
        }

        private static int AlternatingCharacters(string s)
        {
            Console.WriteLine("The string is: " + s);
            int deletions = 0;
            string result = s;

            for (int i=0; i < s.Length; i++)
            {
                if ( ((i + 1) < s.Length) && (s[i] == s[i+1]) )
                {
                    deletions++;
                    //result = s.Remove(i,1);
                }
            }
            Console.WriteLine("Result string is: " + result);
            return deletions;
        }
    }
}
