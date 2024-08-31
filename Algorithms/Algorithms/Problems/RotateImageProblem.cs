using System;

namespace Algorithms.Problems
{
    public class RotateImageProblem
    {
        public void Rotate(int[][] matrix) {
            int n = matrix.Length;
        
            // Step 1: Transpose the matrix
            for (int i = 0; i < n; i++) {
                for (int j = i; j < n; j++) {
                    // Swap elements at position (i, j) with (j, i)
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
        
            // Step 2: Reverse each row
            for (int i = 0; i < n; i++) {
                Array.Reverse(matrix[i]);
            }
        }
    }
}