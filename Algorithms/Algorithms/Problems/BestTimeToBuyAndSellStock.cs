using System;

namespace Algorithms.Problems
{
    public class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices) {
            int l = 0;
            int r = 1;
            int best = 0;

            while (r < prices.Length)
            {
                if (prices[r] > prices[l])
                {
                    var prof = prices[r] - prices[l];
                    best = Math.Max(prof, best);
                }
                else
                {
                    l = r;
                }

                r++;
            }

            return best;
        }
    }
}