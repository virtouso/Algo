namespace Algorithms.Problems
{
    public class ClimbingStairs
    {
       // You are climbing a staircase. It takes n steps to reach the top.
        //    Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
        
        public int ClimbStairs2(int n)
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


        public int ClimbStairs(int n)
        {
            return ClimbStairsWithDecisionTree(n);
        }


        public int ClimbStairsWithDecisionTree(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 2;
            int result = 0;
          //  for (int i = 0; i < 2; i++)
           // {
                result += ClimbRecursive(1, n);
                result += ClimbRecursive(2, n);
          //  }

            return result;
        }

        private int ClimbRecursive(int cur, int fin)
        {
            var result = 0;

            bool min = cur < fin;
            bool minLast = cur + 1 < fin;
            if (min)
                result += ClimbRecursive(cur + 1, fin);

            if (minLast)
                result += ClimbRecursive(cur + 2, fin);

            if (min || minLast)
                return result;
                
            return 1;
        }
        
    }
}