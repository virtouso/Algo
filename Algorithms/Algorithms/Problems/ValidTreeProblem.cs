namespace Algorithms.Problems
{
    public class ValidTreeProblem
    {
        
        // check graph is tree and has no cycle.
        //
        
        public bool ValidTree(int n, int[][] edges)
        {
            if (edges.Length != n - 1)
            {
                return false; // A valid tree must have exactly n-1 edges
            }

            int[] parent = new int[n];
            for (int i = 0; i < n; i++)
            {
                parent[i] = i;
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

            // Union function
            bool Union(int x, int y)
            {
                int rootX = Find(x);
                int rootY = Find(y);

                if (rootX == rootY)
                {
                    return false; // Cycle detected
                }

                parent[rootX] = rootY;
                return true;
            }

            // Process all edges
            foreach (var edge in edges)
            {
                if (!Union(edge[0], edge[1]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}