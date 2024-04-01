namespace Algorithms.Problems
{
    public class CountingBits
    {
        //For each number i, we use the fact that the number of set bits in i is equal to the number of set bits in i / 2 plus the least significant bit of i.
        // most performant O(n)
        public int[] CountBits(int n)
        {
            int[] result = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                result[i] = result[i >> 1] + (i & 1);
            }
            return result;
        }
        
        
        
        // easier. slower.
        public int[] CountBits2(int num) {
            int[] result = new int[num + 1];
        
            for (int i = 0; i <= num; i++) {
                result[i] = CountOnes(i);
            }
        
            return result;
        }
    
        private int CountOnes(int num) {
            int count = 0;
            while (num != 0) {
                count++;
                num = num & (num - 1); // Clear the least significant bit set
            }
            return count;
        }
        
        
        
    }
}