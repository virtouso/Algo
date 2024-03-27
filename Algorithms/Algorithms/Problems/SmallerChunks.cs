using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class SmallerChunks
    {
      public  List<decimal> MakeSmallerChunks(decimal maxChunksSize, decimal all)
        {
            var result = new List<decimal>();

            if (all == 0)
                return result;
            decimal remained = all;
            while (remained >= maxChunksSize)
            {
                remained -= maxChunksSize;
                result.Add(maxChunksSize);
            }

            if (remained > 0)
                result.Add(remained);
            return result;
        }
    }
}