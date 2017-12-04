using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Kata_RepeatChop_And_FizzBuzz
{
    public static class StringExtension
    {
        public static string RemoveConsecuitiveChars(this string s, int ConsecutiveAllowed)
        {
            // Create a hasset to only put unique characters
            HashSet<Char> charSet = new HashSet<char>();
            // Put each distinct character of the string in the hasset
            charSet.UnionWith(s.ToCharArray());

            // Create a temporary string to hold the intermediate string to be returned
            string result = "";


            // Although the following loop has a time complexity of O(N), but for real 
            // world examples, the time differences won't matter a lot because this 
            // function will be used to get rid of repetitive phrases/words, which are not long.
            // Iterate through the character hasset ->
            foreach(Char c in charSet)
            {
                // For the number of consecutives allowed, put that number of
                // characters and build the string to be returned
                for (int i = 0; i < ConsecutiveAllowed; i++)
                    result += c.ToString();
            }

            return result;
        }
    }
}
