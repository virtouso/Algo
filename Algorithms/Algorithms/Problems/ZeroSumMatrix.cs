using System;

namespace Algorithms.Problems
{
    public class ZeroSumMatrix
    {
        public int[,] Calc(int[,] input)
        {

            int m = input.GetLength(0);
            int n = input.GetLength(1);
            var result = new int[m,n];

            result[0, 0] = input[0, 0];
            
            for (int i = 1; i < m; i++)
            {
                result[i, 0] = input[i, 0] + result[i - 1, 0];
            }

            for (int i = 1; i < n; i++)
            {
                result[0, i] = input[0, i] + result[0, i-1];
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    result[i, j] = input[i, j] + result[i - 1, j] + result[i, j - 1] - result[i - 1, j - 1];
                }
            }
            

            return result;
        }



        public void Run()
        {
            var result = Calc(new int[,]{{1,1,1},{1,1,1}});
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write($"{result[i,j]} ");
                }
                Console.WriteLine();
            }
            
        }
        
    }
}