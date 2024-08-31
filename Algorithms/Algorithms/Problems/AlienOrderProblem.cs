using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Problems
{
   // Given the following list of words.
   //     ["wrt", "wrf", "er", "ett", "rftt"]
   //The correct order of characters would be "wertf".


    public class AlienOrderProblem
    {
        public string AlienOrder(string[] words)
        {
            Dictionary<char, HashSet<char>> graph = new Dictionary<char, HashSet<char>>();
            Dictionary<char, int> indegree = new Dictionary<char, int>();

            // Initialize the graph and indegree dictionary
            foreach (string word in words)
            {
                foreach (char c in word)
                {
                    if (!graph.ContainsKey(c))
                    {
                        graph[c] = new HashSet<char>();
                        indegree[c] = 0;
                    }
                }
            }

            // Build the graph
            for (int i = 0; i < words.Length - 1; i++)
            {
                string first = words[i];
                string second = words[i + 1];
                int minLen = Math.Min(first.Length, second.Length);

                for (int j = 0; j < minLen; j++)
                {
                    if (first[j] != second[j])
                    {
                        if (!graph[first[j]].Contains(second[j]))
                        {
                            graph[first[j]].Add(second[j]);
                            indegree[second[j]]++;
                        }

                        break;
                    }
                }

                // Check if the second word is a prefix of the first word
                if (first.StartsWith(second) && first.Length > second.Length)
                {
                    return "";
                }
            }

            // Topological Sort using BFS (Kahn's Algorithm)
            Queue<char> queue = new Queue<char>();
            foreach (var entry in indegree)
            {
                if (entry.Value == 0)
                {
                    queue.Enqueue(entry.Key);
                }
            }

            List<char> result = new List<char>();

            while (queue.Count > 0)
            {
                char c = queue.Dequeue();
                result.Add(c);

                foreach (char neighbor in graph[c])
                {
                    indegree[neighbor]--;
                    if (indegree[neighbor] == 0)
                    {
                        queue.Enqueue(neighbor);
                    }
                }
            }

            // If we were able to process all the characters, return the result as a string
            if (result.Count == indegree.Count)
            {
                return new string(result.ToArray());
            }
            else
            {
                return "";
            }
        }
    }
}