using System.Collections;

namespace Algorithms.Problems
{
    public class ReverseBitsProblem
    {
        public uint ReverseBits(uint n) {
            uint ans = 0;
            int power = 31;
            while(n!=0){
                ans += (n&1)<<power;
                n = n>>1;
                power--;
            }
            return ans;
            
        }
    }
}