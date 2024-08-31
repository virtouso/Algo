using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class CountComponentsProblem
    {
        public int CountComponents(int n, int[][] edges)
        {
            int[] parent = new int[n];
            int[] rank = new int[n];
        
            // Initialize each node to be its own parent (self loop)
            for (int i = 0; i < n; i++)
            {
                parent[i] = i;
                rank[i] = 1;
            }

            // Find function with path compression
            int Find(int x)
            {
                if (parent[x] != x)
                {
                    parent[x] = Find(parent[x]);
                }
                return parent[x];
            }

            // Union function with union by rank
            void Union(int x, int y)
            {
                int rootX = Find(x);
                int rootY = Find(y);

                if (rootX != rootY)
                {
                    if (rank[rootX] > rank[rootY])
                    {
                        parent[rootY] = rootX;
                    }
                    else if (rank[rootX] < rank[rootY])
                    {
                        parent[rootX] = rootY;
                    }
                    else
                    {
                        parent[rootY] = rootX;
                        rank[rootX]++;
                    }
                }
            }

            // Union all edges
            foreach (var edge in edges)
            {
                Union(edge[0], edge[1]);
            }

            // Count the number of unique roots (connected components)
            HashSet<int> uniqueComponents = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                uniqueComponents.Add(Find(i));
            }

            return uniqueComponents.Count;
        }
    }
}