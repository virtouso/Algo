namespace Algorithms.Problems
{
    public class ClimbingStairs
    {
       // You are climbing a staircase. It takes n steps to reach the top.
        //    Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
        
        public int ClimbStairs(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            var result = new int[n+1];
            result[0] = 0;
            result[1] = 1;
            result[2] = 2;

            for (int i = 3; i <=n ; i++)
            {
                result[i] = result[i - 1] + result[i - 2];
            }

            return result[n];
        }
        
        private int ClimbStairsRecursive(int n) {
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;
        
            return ClimbStairsRecursive(n - 1) + ClimbStairsRecursive(n - 2);
        }
        
        
    }
}