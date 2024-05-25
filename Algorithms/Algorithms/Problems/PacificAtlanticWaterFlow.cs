using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class PacificAtlanticWaterFlow
    {
        public IList<IList<int>> PacificAtlantic(int[][] heights) {
            var result = new List<IList<int>>();
            if (heights == null || heights.Length == 0 || heights[0].Length == 0) {
                return result;
            }

            int rows = heights.Length;
            int cols = heights[0].Length;
            bool[,] pacificReachable = new bool[rows, cols];
            bool[,] atlanticReachable = new bool[rows, cols];

            for (int i = 0; i < rows; i++) {
                DFS(heights, pacificReachable, int.MinValue, i, 0);
                DFS(heights, atlanticReachable, int.MinValue, i, cols - 1);
            }

            for (int j = 0; j < cols; j++) {
                DFS(heights, pacificReachable, int.MinValue, 0, j);
                DFS(heights, atlanticReachable, int.MinValue, rows - 1, j);
            }

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    if (pacificReachable[i, j] && atlanticReachable[i, j]) {
                        result.Add(new List<int> { i, j });
                    }
                }
            }

            return result;
        }

        private void DFS(int[][] heights, bool[,] reachable, int prevHeight, int x, int y) {
            int rows = heights.Length;
            int cols = heights[0].Length;

            if (x < 0 || x >= rows || y < 0 || y >= cols || reachable[x, y] || heights[x][y] < prevHeight) {
                return;
            }

            reachable[x, y] = true;
            int[][] directions = new int[][] {
                new int[] { 0, 1 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { -1, 0 }
            };

            foreach (var dir in directions) {
                DFS(heights, reachable, heights[x][y], x + dir[0], y + dir[1]);
            }
        }
    }
}