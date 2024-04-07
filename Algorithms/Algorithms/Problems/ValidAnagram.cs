using System;
using System.Linq;

namespace Algorithms.Problems
{
    public class ValidAnagram
    {
        // check is the second one is reordered version of another. 
        // use dictionary or hashmap. but has memory problem.
        // use sorting. time complexity is more but no more memory

        public bool IsAnagram(string s, string t)
        {
            s = String.Concat(s.OrderBy(c => c));
            t = String.Concat(t.OrderBy(c => c));
            return s == t;
        }
    }
}