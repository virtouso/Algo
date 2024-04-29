namespace Algorithms.Problems
{
    public class Search2DMatrix
    {
        public  bool SearchMatrix(int[,] matrix, int target)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Start from the top-right corner of the matrix
            int row = 0;
            int col = cols - 1;

            while (row < rows && col >= 0)
            {
                if (matrix[row, col] == target)
                {
                    return true; // Found the target
                }
                else if (matrix[row, col] < target)
                {
                    // If the current value is less than the target, move down
                    row++;
                }
                else
                {
                    // If the current value is greater than the target, move left
                    col--;
                }
            }

            return false; // Target not found
        }

    }
}