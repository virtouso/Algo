namespace Algorithms.Problems
{
    public class NumberOfIslands
    {
        
        // Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.
        //
        //     An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.
        //
        //

        //     Example 1:
        //
        // Input: grid = [
        // ["1","1","1","1","0"],
        // ["1","1","0","1","0"],
        // ["1","1","0","0","0"],
        // ["0","0","0","0","0"]
        // ]
        // Output: 1
        // Example 2:
        //
        // Input: grid = [
        // ["1","1","0","0","0"],
        // ["1","1","0","0","0"],
        // ["0","0","1","0","0"],
        // ["0","0","0","1","1"]
        // ]
        // Output: 3
 

  
        
        
        
        
        
        
        public int NumIslands(char[][] grid) {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0) {
                return 0;
            }

            int numRows = grid.Length;
            int numCols = grid[0].Length;
            int numIslands = 0;

            for (int i = 0; i < numRows; i++) {
                for (int j = 0; j < numCols; j++) {
                    if (grid[i][j] == '1') {
                        // Found the start of an island, perform DFS to mark all connected land cells
                        DFS(grid, i, j);
                        numIslands++;
                    }
                }
            }

            return numIslands;
        }

        private void DFS(char[][] grid, int row, int col) {
            int numRows = grid.Length;
            int numCols = grid[0].Length;

            if (row < 0 || row >= numRows || col < 0 || col >= numCols || grid[row][col] != '1') {
                return;
            }

            // Mark the current cell as visited
            grid[row][col] = '0';

            // Visit adjacent cells
            DFS(grid, row + 1, col); // Down
            DFS(grid, row - 1, col); // Up
            DFS(grid, row, col + 1); // Right
            DFS(grid, row, col - 1); // Left
        }
    }
}