using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class DesignAddAndSearchWordsDataStructure
    {
        public class WordDictionary {

            private HashSet<string> wordSet;

            public WordDictionary() {
                wordSet = new HashSet<string>();
            }

            public void AddWord(string word) {
                wordSet.Add(word);
            }

            public bool Search(string word) {
                foreach (string w in wordSet) {
                    if (IsMatch(w, word)) {
                        return true;
                    }
                }
                return false;
            }

            private bool IsMatch(string word1, string word2) {
                if (word1.Length != word2.Length) {
                    return false;
                }
                for (int i = 0; i < word1.Length; i++) {
                    if (word2[i] != '.' && word2[i] != word1[i]) {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}