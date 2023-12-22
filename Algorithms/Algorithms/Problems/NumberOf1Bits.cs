namespace Algorithms.Problems
{
    // count number of 1s in a number
    //https://leetcode.com/problems/number-of-1-bits/
    public class NumberOf1Bits
    {
        
        // shift one time to write and count. shift to right is like /2
        public int HammingWeight(uint n) {
            int count = 0;
            while (n != 0)
            {
                count += (int)n & 1;
                n >>= 1;
            }
            return count;
        }
        
        
        
        //Brian Kernighan's Algorithm. its faster. less  loop
        public  int CountSetBitsKernighan(int n)
        {
            int count = 0;
            while (n != 0)
            {
                n &= (n - 1);
                count++;
            }
            return count;
        }
        
    }
}