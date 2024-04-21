using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class SpiralMatrix
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> result = new List<int>();

            if (matrix == null || matrix.Length == 0)
                return result;

            int rows = matrix.Length;
            int cols = matrix[0].Length;

            int top = 0, bottom = rows - 1, left = 0, right = cols - 1;

            while (top <= bottom && left <= right)
            {
                // Traverse top row
                for (int i = left; i <= right; i++)
                    result.Add(matrix[top][i]);
                top++;

                // Traverse right column
                for (int i = top; i <= bottom; i++)
                    result.Add(matrix[i][right]);
                right--;

                // Check if top has crossed bottom, to avoid duplicate traversal
                if (top <= bottom)
                {
                    // Traverse bottom row
                    for (int i = right; i >= left; i--)
                        result.Add(matrix[bottom][i]);
                    bottom--;
                }

                // Check if left has crossed right, to avoid duplicate traversal
                if (left <= right)
                {
                    // Traverse left column
                    for (int i = bottom; i >= top; i--)
                        result.Add(matrix[i][left]);
                    left++;
                }
            }

            return result;
        }
    }
}