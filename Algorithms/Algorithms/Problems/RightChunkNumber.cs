using System;

namespace Algorithms.Problems
{
    public class RightChunkNumber
    {
        // public int CalculateRightChunkNumber(int chunkCount, int current, int max)
        // {
        //     if (current <= 0) return -1;
        //     
        //     float singleChunkMax = (float)max / (float)chunkCount;
        //     for (int i = chunkCount-1; i >= 0; i--)
        //     {
        //         float currentThreshold = (i + 1) * singleChunkMax;
        //         if ( currentThreshold<= current)
        //             return i;
        //     }
        //
        //     return 0;
        // }
        
        
        public int CalculateRightChunkNumber(int chunkCount, int current, int max)
        {
            if (current <= 0) return -1;

            float singleChunkMax = (float)max / (float)chunkCount;
            int index = (int)Math.Floor((float)current / singleChunkMax) - 1;
    
            return Math.Max(index, 0);
        }
        
    }
}