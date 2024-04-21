using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class Trie
    {
        private TrieNode root;

        public Trie()
        {
            root = new TrieNode();
        }

        public void Insert(string word)
        {
            TrieNode node = root;
            foreach (char c in word)
            {
                if (!node.Children.ContainsKey(c))
                {
                    node.Children[c] = new TrieNode();
                }

                node = node.Children[c];
            }

            node.IsEndOfWord = true;
        }

        public bool Search(string word)
        {
            TrieNode node = SearchPrefix(word);
            return node != null && node.IsEndOfWord;
        }

        public bool StartsWith(string prefix)
        {
            return SearchPrefix(prefix) != null;
        }

        private TrieNode SearchPrefix(string prefix)
        {
            TrieNode node = root;
            foreach (char c in prefix)
            {
                if (node.Children.ContainsKey(c))
                {
                    node = node.Children[c];
                }
                else
                {
                    return null;
                }
            }

            return node;
        }

        private class TrieNode
        {
            public Dictionary<char, TrieNode> Children { get; private set; }
            public bool IsEndOfWord { get; set; }

            public TrieNode()
            {
                Children = new Dictionary<char, TrieNode>();
                IsEndOfWord = false;
            }
        }
    }
}