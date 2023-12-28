using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Problems
{
    public class GroupAnagramsProblem
    {
        public IList<IList<string>> GroupAnagrams(string[] strs) {
            Dictionary<string, IList<string>> anagramGroups = new Dictionary<string, IList<string>>();

            foreach (var word in strs)
            {
                char[] charArray = word.ToCharArray();
                Array.Sort(charArray);
                string key = new string(charArray);
                
                if (anagramGroups.ContainsKey(key))
                {
                    anagramGroups[key].Add(word);
                }
                else
                {
                    anagramGroups[key] = new List<string> { word };
                }
            }
            
            return anagramGroups.Values.ToList();
        }
    }
}