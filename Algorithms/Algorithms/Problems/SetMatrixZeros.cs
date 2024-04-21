using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class SetMatrixZeros
    {
        public void SetZeroes(int[][] matrix)
        {
            HashSet<int> rows = new HashSet<int>();
            HashSet<int> cols = new HashSet<int>();

            int m = matrix.Length;
            int n = matrix[0].Length;

            // Iterate through the matrix to find zeroes and store their row and column indices
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        rows.Add(i);
                        cols.Add(j);
                    }
                }
            }

            // Set zeroes for rows
            foreach (int row in rows)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[row][j] = 0;
                }
            }

            // Set zeroes for columns
            foreach (int col in cols)
            {
                for (int i = 0; i < m; i++)
                {
                    matrix[i][col] = 0;
                }
            }
        }
    }
}

