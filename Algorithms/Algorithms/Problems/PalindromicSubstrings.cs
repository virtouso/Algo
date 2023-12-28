namespace Algorithms.Problems
{
    public class PalindromicSubstrings
    {
        
        // even and odd middle indexes and check they are equal.  
        
        public int CountSubstrings(string s)
        {

            int res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                
                // for odds length
                var l = i;
                var r = i;
                while (l>=0 && r<s.Length && s[l]== s[r])
                {
                    res += 1;
                    l--;
                    r++;
                }

                l = i;
                r = i + 1;

                while (l>=0 && r< s.Length && s[r]==s[l])
                {
                    res += 1;
                    l--;
                    r++;
                }

            }
            return res;
        }
    }
}