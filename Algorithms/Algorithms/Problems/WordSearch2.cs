using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class WordSearch2
    {
     //   board = [["o","a","a","n"],["e","t","a","e"],["i","h","k","r"],["i","f","l","v"]]
     //   words = ["oath","pea","eat","rain"]
        
        public class TrieNode {
            public TrieNode[] Children = new TrieNode[26];
            public string Word = null;
        }

        public class Trie {
            private TrieNode root;

            public Trie() {
                root = new TrieNode();
            }

            public void Insert(string word) {
                TrieNode node = root;
                foreach (char c in word) {
                    int index = c - 'a';
                    if (node.Children[index] == null) {
                        node.Children[index] = new TrieNode();
                    }
                    node = node.Children[index];
                }
                node.Word = word;
            }

            public TrieNode GetRoot() {
                return root;
            }
        }
        
        
            private int[,] directions = new int[,] { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };

    public IList<string> FindWords(char[][] board, string[] words) {
        List<string> result = new List<string>();
        Trie trie = new Trie();

        // Build the Trie
        foreach (string word in words) {
            trie.Insert(word);
        }

        TrieNode root = trie.GetRoot();

        // Start DFS from each cell
        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board[i].Length; j++) {
                if (root.Children[board[i][j] - 'a'] != null) {
                    DFS(board, i, j, root, result);
                }
            }
        }

        return result;
    }

    private void DFS(char[][] board, int row, int col, TrieNode node, List<string> result) {
        char c = board[row][col];
        int index = c - 'a';
        TrieNode currentNode = node.Children[index];

        if (currentNode == null) {
            return;
        }

        if (currentNode.Word != null) {
            result.Add(currentNode.Word);
            currentNode.Word = null;  // Avoid duplicate entries
        }

        // Mark the current cell as visited
        board[row][col] = '#';

        // Explore all 4 directions
        for (int i = 0; i < 4; i++) {
            int newRow = row + directions[i, 0];
            int newCol = col + directions[i, 1];

            if (newRow >= 0 && newRow < board.Length && newCol >= 0 && newCol < board[0].Length && board[newRow][newCol] != '#') {
                DFS(board, newRow, newCol, currentNode, result);
            }
        }

        // Restore the original value (backtracking)
        board[row][col] = c;

        // Optional optimization: Remove leaf nodes
        if (IsLeaf(currentNode)) {
            node.Children[index] = null;
        }
    }

    private bool IsLeaf(TrieNode node) {
        foreach (var child in node.Children) {
            if (child != null) {
                return false;
            }
        }
        return true;
    }
    }
}